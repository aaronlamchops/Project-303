using UnityEngine;
using System.Collections;

public class StatMod
{
	public int ModVal{get; set;}
	
	public StatMod(int modVal)
	{
		this.ModVal = modVal;
		Debug.log("Stat modification initiated");
	}


}