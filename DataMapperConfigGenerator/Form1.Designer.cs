namespace DataMapperConfigGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDriver = new System.Windows.Forms.TextBox();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGetDatabases = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.checkBoxTables = new System.Windows.Forms.CheckBox();
            this.checkBoxViews = new System.Windows.Forms.CheckBox();
            this.buttonGetColumns = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonTabPage1Next = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonQuery = new System.Windows.Forms.RadioButton();
            this.radioButtonTable = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxFisheriesDataType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewMapping = new System.Windows.Forms.DataGridView();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Source_Processed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonTabPage2Next = new System.Windows.Forms.Button();
            this.textBoxJSON = new System.Windows.Forms.TextBox();
            this.buttonGenerateJSON = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMapping)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDriver
            // 
            this.textBoxDriver.Location = new System.Drawing.Point(154, 58);
            this.textBoxDriver.Name = "textBoxDriver";
            this.textBoxDriver.Size = new System.Drawing.Size(310, 20);
            this.textBoxDriver.TabIndex = 0;
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(154, 84);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(310, 20);
            this.textBoxServer.TabIndex = 1;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(154, 110);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(310, 20);
            this.textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(154, 136);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(310, 20);
            this.textBoxPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Driver";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // buttonGetDatabases
            // 
            this.buttonGetDatabases.Location = new System.Drawing.Point(506, 160);
            this.buttonGetDatabases.Name = "buttonGetDatabases";
            this.buttonGetDatabases.Size = new System.Drawing.Size(114, 23);
            this.buttonGetDatabases.TabIndex = 8;
            this.buttonGetDatabases.Text = "Get Tables/Views";
            this.buttonGetDatabases.UseVisualStyleBackColor = true;
            this.buttonGetDatabases.Click += new System.EventHandler(this.buttonGetDatabases_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Database";
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.Enabled = false;
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(132, 26);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(310, 21);
            this.comboBoxTables.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tables and Views";
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(154, 162);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(310, 20);
            this.textBoxDatabase.TabIndex = 13;
            // 
            // checkBoxTables
            // 
            this.checkBoxTables.AutoSize = true;
            this.checkBoxTables.Checked = true;
            this.checkBoxTables.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTables.Location = new System.Drawing.Point(658, 164);
            this.checkBoxTables.Name = "checkBoxTables";
            this.checkBoxTables.Size = new System.Drawing.Size(64, 17);
            this.checkBoxTables.TabIndex = 14;
            this.checkBoxTables.Text = "Tables?";
            this.checkBoxTables.UseVisualStyleBackColor = true;
            // 
            // checkBoxViews
            // 
            this.checkBoxViews.AutoSize = true;
            this.checkBoxViews.Location = new System.Drawing.Point(750, 164);
            this.checkBoxViews.Name = "checkBoxViews";
            this.checkBoxViews.Size = new System.Drawing.Size(60, 17);
            this.checkBoxViews.TabIndex = 15;
            this.checkBoxViews.Text = "Views?";
            this.checkBoxViews.UseVisualStyleBackColor = true;
            // 
            // buttonGetColumns
            // 
            this.buttonGetColumns.Location = new System.Drawing.Point(458, 354);
            this.buttonGetColumns.Name = "buttonGetColumns";
            this.buttonGetColumns.Size = new System.Drawing.Size(114, 23);
            this.buttonGetColumns.TabIndex = 16;
            this.buttonGetColumns.Text = "Get Columns";
            this.buttonGetColumns.UseVisualStyleBackColor = true;
            this.buttonGetColumns.Click += new System.EventHandler(this.buttonGetColumns_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(496, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "Data Mapper Config Generator Example";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(44, 220);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(913, 480);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonTabPage1Next);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBoxQuery);
            this.tabPage1.Controls.Add(this.comboBoxTables);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.buttonGetColumns);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(905, 454);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Table/Query";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonTabPage1Next
            // 
            this.buttonTabPage1Next.Enabled = false;
            this.buttonTabPage1Next.Location = new System.Drawing.Point(768, 398);
            this.buttonTabPage1Next.Name = "buttonTabPage1Next";
            this.buttonTabPage1Next.Size = new System.Drawing.Size(75, 23);
            this.buttonTabPage1Next.TabIndex = 21;
            this.buttonTabPage1Next.Text = "Next";
            this.buttonTabPage1Next.UseVisualStyleBackColor = true;
            this.buttonTabPage1Next.Click += new System.EventHandler(this.buttonTabPage1Next_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonQuery);
            this.groupBox1.Controls.Add(this.radioButtonTable);
            this.groupBox1.Location = new System.Drawing.Point(522, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 293);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonQuery
            // 
            this.radioButtonQuery.AutoSize = true;
            this.radioButtonQuery.Location = new System.Drawing.Point(15, 94);
            this.radioButtonQuery.Name = "radioButtonQuery";
            this.radioButtonQuery.Size = new System.Drawing.Size(75, 17);
            this.radioButtonQuery.TabIndex = 20;
            this.radioButtonQuery.Text = "Use Query";
            this.radioButtonQuery.UseVisualStyleBackColor = true;
            // 
            // radioButtonTable
            // 
            this.radioButtonTable.AutoSize = true;
            this.radioButtonTable.Checked = true;
            this.radioButtonTable.Location = new System.Drawing.Point(16, 29);
            this.radioButtonTable.Name = "radioButtonTable";
            this.radioButtonTable.Size = new System.Drawing.Size(74, 17);
            this.radioButtonTable.TabIndex = 19;
            this.radioButtonTable.TabStop = true;
            this.radioButtonTable.Text = "Use Table";
            this.radioButtonTable.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Query";
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Enabled = false;
            this.textBoxQuery.Location = new System.Drawing.Point(132, 65);
            this.textBoxQuery.Multiline = true;
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(310, 234);
            this.textBoxQuery.TabIndex = 17;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonTabPage2Next);
            this.tabPage2.Controls.Add(this.dataGridViewMapping);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.comboBoxFisheriesDataType);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(905, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Columns";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxFisheriesDataType
            // 
            this.comboBoxFisheriesDataType.FormattingEnabled = true;
            this.comboBoxFisheriesDataType.Location = new System.Drawing.Point(120, 16);
            this.comboBoxFisheriesDataType.Name = "comboBoxFisheriesDataType";
            this.comboBoxFisheriesDataType.Size = new System.Drawing.Size(187, 21);
            this.comboBoxFisheriesDataType.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Fisheries Data Type";
            // 
            // dataGridViewMapping
            // 
            this.dataGridViewMapping.AllowUserToAddRows = false;
            this.dataGridViewMapping.AllowUserToDeleteRows = false;
            this.dataGridViewMapping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMapping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Destination,
            this.Source,
            this.Source_Processed});
            this.dataGridViewMapping.Location = new System.Drawing.Point(16, 54);
            this.dataGridViewMapping.Name = "dataGridViewMapping";
            this.dataGridViewMapping.Size = new System.Drawing.Size(556, 381);
            this.dataGridViewMapping.TabIndex = 2;
            // 
            // Destination
            // 
            this.Destination.HeaderText = "Destination";
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            // 
            // Source
            // 
            this.Source.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Source.DisplayStyleForCurrentCellOnly = true;
            this.Source.HeaderText = "Source";
            this.Source.Name = "Source";
            this.Source.Width = 150;
            // 
            // Source_Processed
            // 
            this.Source_Processed.HeaderText = "Source_Processed";
            this.Source_Processed.Name = "Source_Processed";
            this.Source_Processed.Width = 150;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonGenerateJSON);
            this.tabPage3.Controls.Add(this.textBoxJSON);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(905, 454);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "JSON";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonTabPage2Next
            // 
            this.buttonTabPage2Next.Enabled = false;
            this.buttonTabPage2Next.Location = new System.Drawing.Point(795, 412);
            this.buttonTabPage2Next.Name = "buttonTabPage2Next";
            this.buttonTabPage2Next.Size = new System.Drawing.Size(75, 23);
            this.buttonTabPage2Next.TabIndex = 22;
            this.buttonTabPage2Next.Text = "Next";
            this.buttonTabPage2Next.UseVisualStyleBackColor = true;
            this.buttonTabPage2Next.Click += new System.EventHandler(this.buttonTabPage2Next_Click);
            // 
            // textBoxJSON
            // 
            this.textBoxJSON.Location = new System.Drawing.Point(48, 28);
            this.textBoxJSON.Multiline = true;
            this.textBoxJSON.Name = "textBoxJSON";
            this.textBoxJSON.Size = new System.Drawing.Size(646, 387);
            this.textBoxJSON.TabIndex = 0;
            // 
            // buttonGenerateJSON
            // 
            this.buttonGenerateJSON.Enabled = false;
            this.buttonGenerateJSON.Location = new System.Drawing.Point(781, 374);
            this.buttonGenerateJSON.Name = "buttonGenerateJSON";
            this.buttonGenerateJSON.Size = new System.Drawing.Size(75, 41);
            this.buttonGenerateJSON.TabIndex = 23;
            this.buttonGenerateJSON.Text = "Generate JSON";
            this.buttonGenerateJSON.UseVisualStyleBackColor = true;
            this.buttonGenerateJSON.Click += new System.EventHandler(this.buttonGenerateJSON_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 712);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBoxViews);
            this.Controls.Add(this.checkBoxTables);
            this.Controls.Add(this.textBoxDatabase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonGetDatabases);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.textBoxDriver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMapping)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDriver;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonGetDatabases;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.CheckBox checkBoxTables;
        private System.Windows.Forms.CheckBox checkBoxViews;
        private System.Windows.Forms.Button buttonGetColumns;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonQuery;
        private System.Windows.Forms.RadioButton radioButtonTable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonTabPage1Next;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxFisheriesDataType;
        private System.Windows.Forms.DataGridView dataGridViewMapping;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewComboBoxColumn Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source_Processed;
        private System.Windows.Forms.Button buttonTabPage2Next;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonGenerateJSON;
        private System.Windows.Forms.TextBox textBoxJSON;
    }
}

