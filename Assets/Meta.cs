using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Meta
{
	public string offset;
	public string limit;
	public int count;
	public int program;
	public int clip;

	public int GetCount(){
		return count;		
	}
}