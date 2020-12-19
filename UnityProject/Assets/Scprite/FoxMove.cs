﻿using System.Collections;
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