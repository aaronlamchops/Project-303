using UnityEngine;
using System.Collection.Generic;

public class CharacterStats : MonoBehaviour {
	public List<BaseStat> stats = new List<BaseStat>():
	
	void Start()
	{
		stats.Add(new BaseStat(4, "Attack"));
		stats[0].AddStatBOnus(new StatBonus(5));
		Debug.Log(stats[0].GetCalculatedStatValue());
	
	}
	
}