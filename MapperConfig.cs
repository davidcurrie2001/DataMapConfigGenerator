using System;


[DataContract]
public class MapperConfig
{
    [DataMember]
    public string connection { get; set; }

    [DataMember]
    public string table { get; set; }

    [DataMember]
    public Dictionary<int, string>  fields { get; set; }


    public MapperConfig()
	{

	}
}
