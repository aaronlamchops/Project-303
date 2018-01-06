using UnityEngine;
using System.Collections;

public class Figure : MonoBehaviour {
    public int hp;
    public int atk;
    public int speed;

    public Rigidbody2D rigid2D;                  //RigidBody attached to object 
    private BoxCollider2D boxCollider;             //BoxCollider2D attached to object
    private LayerMask collisionLayer;              //layer that collisions are detected on

    protected virtual void Start()
    {
        //set boxCollider to the BoxCollier2D of this object;
        boxCollider = GetComponent<BoxCollider2D>();

        //set rigid2D to the RigidBody2D attached to this object
        rigid2D = GetComponent<Rigidbody2D>();
    }
    
   /* protected bool CanMove (int x, int y, out RaycastHit2D hit)
    {
        return true;
        //checks if figure can move

        
        //store starting position
        Vector2 moveFrom = transform.position;


        //calculate end position
        Vector2 moveTo = moveFrom + new Vector2(x, y);
    }*/


    private void OnDestroy()
    {
        //TODO
    }
}
