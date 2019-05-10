using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMapperConfigGenerator
{
    public partial class Form1 : Form
    {

        DataTable dataColumns;
        string connectionString;
        string table;

        string[] fisheriesDataTypes = new string[] { "Biological", "Length Freq. (not implemented)", "Gear Params (not implemented)" };
        string[] BiologicalFields = new string[] { "SurveyName", "SurveyYear", "SurveyMonth", "HaulNumber", "SampleID", "Species", "Length", "Weight", "Sex", "Maturity", "Age" };

        public Form1()
        {
            InitializeComponent();


            textBoxDriver.Text = "SQL Server";
            textBoxServer.Text = "Your_Server";
            textBoxUsername.Text = "Your_User_Name";
            textBoxPassword.Text = "";
            textBoxDatabase.Text = "Your_Database";

            dataColumns = null;
            connectionString = "";
            table = "";

            comboBoxFisheriesDataType.Items.AddRange(fisheriesDataTypes);
            comboBoxFisheriesDataType.SelectedIndexChanged += ComboBoxFisheriesDataType_SelectedIndexChanged;

        }

        private void ComboBoxFisheriesDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateColumnsGrid();

        }


        private void PopulateColumnsGrid()
        {
            buttonTabPage2Next.Enabled = false;
            buttonGenerateJSON.Enabled = false;

            dataGridViewMapping.Rows.Clear();
            dataGridViewMapping.Refresh();

            // Biological
            if (comboBoxFisheriesDataType.SelectedItem.ToString() == fisheriesDataTypes[0])
            {
                DataGridViewComboBoxColumn myComboCol = (DataGridViewComboBoxColumn) dataGridViewMapping.Columns["Source"];
                myComboCol.DataSource = dataColumns.AsEnumerable().Select(s => s.Field<string>("ColumnName")).ToArray<string>();

                foreach (string s in BiologicalFields)
                {
                    int newIndex = dataGridViewMapping.Rows.Add();

                    dataGridViewMapping.Rows[newIndex].Cells[0].Value = s;

                }

                buttonTabPage2Next.Enabled = true;
                buttonGenerateJSON.Enabled = true;

            }
            // Length Freq
            else if (comboBoxFisheriesDataType.SelectedItem.ToString() == fisheriesDataTypes[0])
            {
                // TODO

            }
            // Gear Params
            else if (comboBoxFisheriesDataType.SelectedItem.ToString() == fisheriesDataTypes[0])
            {

                // TODO
            }

        }

        private void buttonGetDatabases_Click(object sender, EventArgs e)
        {
            try
            {
                GetTables();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private bool GetTables()
        {
            bool successful = false;

            dataColumns = null;

            string TableCollectionName = "Tables";
            string ViewCollectionName = "Views";

            List<string> TableAndViewNames = new List<string>();

            connectionString = string.Format("Driver={0}; Server={1}; Database={2}; Uid={3};Pwd={4};", textBoxDriver.Text, textBoxServer.Text, textBoxDatabase.Text, textBoxUsername.Text, textBoxPassword.Text);

            DataTable CollectionsAvailable = null;
            DataTable TablesAvailable = null;
            DataTable ViewsAvailable = null;


            comboBoxTables.Enabled = false;
            textBoxQuery.Enabled = false;
            buttonTabPage1Next.Enabled = false;

            using (OdbcConnection myConnection = new OdbcConnection(connectionString))
            {
                myConnection.Open();
                CollectionsAvailable = myConnection.GetSchema();

                DataRow[] foundRows;
                foundRows = CollectionsAvailable.Select("CollectionName = '" + TableCollectionName + "'");

                // If we want to include tables
                if (checkBoxTables.Checked)
                {

                    // if TABLES exists
                    if (foundRows != null && foundRows.Length > 0)
                    {
                        TablesAvailable = myConnection.GetSchema(TableCollectionName);
                    }

                    foundRows = null;
                    foundRows = CollectionsAvailable.Select("CollectionName = '" + ViewCollectionName + "'");

                    // SQL Server will return TABLE_SCHEM and TABLE_NAME - other databases return different columns 
                    // see https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/odbc-schema-collections
                    if (TablesAvailable != null && TablesAvailable.Columns != null && TablesAvailable.Columns.Contains("TABLE_SCHEM") && TablesAvailable.Columns.Contains("TABLE_NAME"))
                    {
                        foreach (DataRow dr in TablesAvailable.Rows)
                        {
                            if (dr["TABLE_SCHEM"].ToString() != "sys")
                            {
                                string tableName = dr["TABLE_SCHEM"] + "." + dr["TABLE_NAME"];
                                TableAndViewNames.Add(tableName);
                            }
                        }
                    }

                }

                // If we want to include views
                if (checkBoxViews.Checked)
                {

                    // if VIEWS exists
                    if (foundRows != null && foundRows.Length > 0)
                    {
                        ViewsAvailable = myConnection.GetSchema(ViewCollectionName);
                    }

                    // SQL Server will return TABLE_SCHEM and TABLE_NAME - other databases return different columns 
                    // see https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/odbc-schema-collections
                    if (ViewsAvailable != null && ViewsAvailable.Columns != null && ViewsAvailable.Columns.Contains("TABLE_SCHEM") && ViewsAvailable.Columns.Contains("TABLE_NAME"))
                    {
                        foreach (DataRow dr in ViewsAvailable.Rows)
                        {
                            if (dr["TABLE_SCHEM"].ToString() != "sys")
                            {
                                string tableName = dr["TABLE_SCHEM"] + "." + dr["TABLE_NAME"];
                                TableAndViewNames.Add(tableName);
                            }
                        }
                    }

                }

                if (TableAndViewNames != null && TableAndViewNames.Count > 0)
                {
                    successful = true;

                    comboBoxTables.Enabled = true;
                    textBoxQuery.Enabled = true;

                    foreach (string tableName in TableAndViewNames)
                    {
                        comboBoxTables.Items.Add(tableName);

                    }


                }

                myConnection.Close();

                return successful;
            }
        }

        private void buttonGetColumns_Click(object sender, EventArgs e)
        {
            buttonTabPage1Next.Enabled = false;
            try
            {
                if (GetColumns())
                {
                    buttonTabPage1Next.Enabled = true;

                }


            } catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private bool GetColumns()
        {
            bool successful = false;

            dataColumns = null;

            connectionString = string.Format("Driver={0}; Server={1}; Database={2}; Uid={3};Pwd={4};", textBoxDriver.Text, textBoxServer.Text, textBoxDatabase.Text, textBoxUsername.Text, textBoxPassword.Text);

            string queryString = "";

            if (radioButtonTable.Checked)
            {
                table = comboBoxTables.SelectedItem.ToString();
                queryString = "select * from " + table;

            } else if (radioButtonQuery.Checked)
            {
                // remove the first part of the query string
                int fromLocation = textBoxQuery.Text.IndexOf("FROM", StringComparison.InvariantCultureIgnoreCase);
                if (fromLocation >= 0) {

                    table = textBoxQuery.Text.Substring(fromLocation + 4);
                    queryString = "select * from " + table;
                    textBoxQuery.Text = queryString;
                }

            }

            // try and get the column information
            using (OdbcConnection myConnection = new OdbcConnection(connectionString))
            using (OdbcCommand com = new OdbcCommand(queryString, myConnection))
            {
                myConnection.Open();

                using (OdbcDataReader reader = com.ExecuteReader(System.Data.CommandBehavior.SchemaOnly))
                {
                    dataColumns = reader.GetSchemaTable();

                    // TODO - how should we deal with ambiguous column names?

                    // Add an extra row with a blank column name
                    DataRow blankRow = dataColumns.NewRow();
                    blankRow["ColumnName"] = "";
                    dataColumns.Rows.InsertAt(blankRow, 0);


                    successful = true;
                }
                myConnection.Close();
            }

            return successful;

        }

        private bool GenerateJSON()
        {
            bool successful = false;

            // Generate the MapperConfig object
            MapperConfig mc = new MapperConfig();

            mc.connection = connectionString;
            mc.table = table;

            // Read through the DataGridView to get the list of field mappings
            List<MapperField> myFields = new List<MapperField>();

            foreach (DataGridViewRow dr in dataGridViewMapping.Rows)
            {
                DataGridViewCell cellDestination = dr.Cells[0];
                DataGridViewCell cellSource = dr.Cells[1];
                DataGridViewCell cellSourceProcessed = dr.Cells[2];

                // Check Source_Processed column first (column 2)
                if (cellSourceProcessed != null && cellSourceProcessed.Value != null && cellSourceProcessed.Value.ToString() != "" && cellDestination != null && cellDestination.Value != null)
                {
                    myFields.Add(new MapperField(cellSourceProcessed.Value.ToString(), cellDestination.Value.ToString()));

                }
                // Now check Source column (column 1)
                else if (cellSource != null && cellSource.Value != null && cellSource.Value.ToString() != "" && cellDestination !=null && cellDestination.Value != null)
                {
                    myFields.Add(new MapperField(cellSource.Value.ToString(), cellDestination.Value.ToString()));
                }

            }

            mc.fields = myFields.ToArray();

            // Try serialising the MapperConfig object to JSON
            var myJson = JsonConvert.SerializeObject(mc);



            if (myJson != null && myJson.Length > 0){
                textBoxJSON.Text = myJson;
                successful = true;
            }


            return successful;
        }

        private void buttonTabPage1Next_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void buttonTabPage2Next_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void buttonGenerateJSON_Click(object sender, EventArgs e)
        {
            try
            {
                GenerateJSON();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
