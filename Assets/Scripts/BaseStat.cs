using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStat {
	
	public List<StatMod> BaseAdd{get; set;}
	public int BaseVal {get; set;}
	public string StatName {get; set;}
	public int FinalVal{get; set;}
	
	public BaseStat(int baseVal, string statName}
	{
	
		this.BaseAdd = new List<StatMod>();
		this.BaseVal = baseVal;
		this.StatName = statName;
		//private float speed;
		//private float maxSpeed;
		//public int startHp;
		//public int hp;
		//public int atk;

	}
	
	public void AddStatMod(StatMod statMod)
	{
		this.BaseAdd.Add(statMod);
	}
	
	public void RemoveStatMod(StatMod statMod)
	{
		this.BaseAdd.Remove(statMod);
	}
	
	public int GetModifiedStat()
	{
			this.BaseAdd.ForEach(x => this.FinalValue += x.);
			return FialValue
		
	}

}