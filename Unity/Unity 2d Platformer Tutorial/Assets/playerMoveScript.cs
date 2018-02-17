using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoveScript : MonoBehaviour {

	public int playerSpeed = 10;
	private bool facingRight = false;
	public int playerJumpPower = 1250;
	private float moveX;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		playerMove();
	}

	void playerMove(){
		 // controls
		 moveX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            jump();
        }
		 // animation
		 // player direction
		 if (moveX < 0.0f & !facingRight){
			 flipPlayer();
		 }
		 else if (moveX > 0.0f & facingRight){
			 flipPlayer();
		 }
		 // physics
		 gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
	}

	void jump(){
        // jump code
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
	}

	void flipPlayer(){
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
	}
}
