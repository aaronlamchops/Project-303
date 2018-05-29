using UnityEngine;
using System.Collections;

public class Figure : MonoBehaviour {

	public LayerMask blockingLayer;

    public Rigidbody2D rigid2D;                  //RigidBody attached to object 
    private BoxCollider2D boxCollider;             //BoxCollider2D attached to object
    private LayerMask collisionLayer;              //layer that collisions are detected on
	
	private float walkSpeed;
	
	private CharacterStat figureStat;
	
	
	
    protected virtual void Start()
    {
        //set boxCollider to the BoxCollier2D of this object;
        boxCollider = GetComponent<BoxCollider2D>();

        //set rigid2D to the RigidBody2D attached to this object
        rigid2D = GetComponent<Rigidbody2D>();
		
		figureStatStat = GetComponent<CharacterStat>();
		
		walkSpeed = (float)(figureStat.Speed);
		runSpeed = walkSpeed + (walkSpeed/2);
    }
    
	
    /*protected bool CanMove (int xDirection, int yDirection, out RaycastHit2D hit)
    {
		

    }*/
	
	public void takeDamage(int dmg)
	{
		hp -= dmg;
		
	}
	
	protected abstract void Move()
	{
		curSpeed = walkSpeed;
		maxSpeed = curSpeed;
		
		rigid2D.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal")*curSpeed, 0.8f), Mathf.Lerp(0, Input.GetAxis("Vertical")*curSpeed, 0.8f));
	}
	
	protected virtual void Update()
	{
		if(hp <= 0){
			Die();
		}
		
		Move();
		//Updates Figure movement  by applying a velocity to Figure rigid2D body 
	}


    private void Die()
    {
		gameObject.SetActive(false);
		isDead = true;
        //TODO
    }
}
