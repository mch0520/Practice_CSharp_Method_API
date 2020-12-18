using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxMove : MonoBehaviour
{
	//狐狸的移動速度
	public float speed;
	//箱子的圖片渲染器
	public SpriteRenderer mySpriteR;
	//狐狸
	public Rigidbody2D fox;
	//箱子的碰撞器  Transform
	public BoxCollider2D boxCol;
	public Transform boxTra;

	public void Start()
	{
		mySpriteR = GetComponent<SpriteRenderer>();
		fox = GetComponent<Rigidbody2D>();
		boxTra = GetComponent<Transform>();
		boxCol = GetComponent<BoxCollider2D>();
	}
	public void Move(float speed)
	{
		speed *= Input.GetAxisRaw("Horizontal");
		if(Input.GetKeyDown("a"))
		{
			speed *= -1;
		}
		if(Input.GetKeyDown("d"))
        {
			Mathf.Abs(speed);
        }
		fox.AddForce(new Vector2(speed, 0));

		if(Input.GetAxisRaw("Horizontal")>0)
        {
			mySpriteR.flipX = false;
        }
		else
        {
			mySpriteR.flipX = true;
        }

	}
		
	
	public void Update()
	{
	   Move(speed);


	}
}