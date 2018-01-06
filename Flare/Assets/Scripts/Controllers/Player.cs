using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Figure {

    private Hashtable skills = new Hashtable();
    private Hashtable inventory = new Hashtable();
    private int maxHP;

	// Use this for initialization
	void Start () {
        maxHP = 50;
        hp = maxHP;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void AttemptMove ()
    {


    }

    void Attack()
    {


    }

    void UseSkill()
    {


    }

   void TakeDamage(int damage)
    {
        hp -= damage;
    }

    void Heal(int healPoints)
    {
        hp += healPoints;
    }
}
