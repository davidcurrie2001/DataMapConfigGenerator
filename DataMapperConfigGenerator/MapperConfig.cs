using System;
using System.Collections.Generic;

public class MapperConfig
{

    public string connection { get; set; }


    public string table { get; set; }


    public MapperField[] fields { get; set; }


    public MapperConfig()
	{

	}
}


public class MapperField
{
    public string source { get; set; }
    public string destination { get; set; }

    public MapperField(string NewSource, string NewDestination)
    {
        source = NewSource;
        destination = NewDestination;

    }

}
