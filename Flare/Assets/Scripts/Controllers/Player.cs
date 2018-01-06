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
	void FixedUpdate () {
        //Store the current horizontal input in moveHorizontal
        float horizontalMove = Input.GetAxis("Horixontal");

        float verticalMove = Input.GetAxis("Vertical");

        //use the vertical and horizontal floats to create a new Vector
        Vector2 movement = new Vector2(horizontalMove, verticalMove);

        rigid2D.AddForce(movement * speed);
	}

    void Move ()
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
