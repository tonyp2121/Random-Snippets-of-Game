using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMoves : MonoBehaviour {

    public int enemySpeed = 3;
    public int xMoveDirection = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(xMoveDirection, 0));
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (xMoveDirection, 0) * enemySpeed;
       if (hit.distance < 0.6f)
        {
            flip();
        }
    }
    void flip()
    {
        xMoveDirection *= -1;
    }
}
