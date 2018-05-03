using UnityEngine;
using System;
using System.IO;
using System.Collections.Generic;

[System.Serializable]
public class YleData
{
	public string apiVersion;
	public Meta meta;
	public List<Datum> data;

	public static YleData CreateFromJSON(string jsonString)
	{
		
		return JsonUtility.FromJson<YleData>(jsonString);
	}

}
