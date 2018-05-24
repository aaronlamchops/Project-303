using UnityEngine;
using System.Collections;

public class Enemy : Figure
{
    private Hashtable skills = new Hashtable();

    public void takeDamage(int damage){
        this.hp = this.hp - damage;
    }

	// Use this for initialization
	void Start()
	{
        //TODO
	}

	// Update is called once per frame
	void Update()
	{
		//TODO
	}
}
