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

	public void Start()
	{
		mySpriteR = GetComponent<SpriteRenderer>();
		fox = GetComponent<Rigidbody2D>();
		mySpriteR= GameObject.Find("fox").GetComponent<SpriteRenderer>();
		fox = GameObject.Find("fox").GetComponent<Rigidbody2D>();
	}
	public void Move(float speed)
	{
		if(Input.GetKey(KeyCode.A)&Input.GetKey(KeyCode.LeftArrow))
		{
			speed *= Input.GetAxisRaw("Horizontal");
			mySpriteR.flipX = true;
			fox.AddForce(new Vector2(speed, 0));
		}
		else if(Input.GetKey(KeyCode.D)&Input.GetKey(KeyCode.RightArrow))
        {
			speed *= Input.GetAxisRaw("Horizontal");
			mySpriteR.flipX = false;
			fox.AddForce(new Vector2(speed, 0));
		}
		
	}
		
	
	public void Update()
	{
	   Move(speed);
		if(Input.anyKey)
        {
			print("input success");
        }
		if(Input.GetKey("a"))
        {
			print("input a");
        }
	}
}