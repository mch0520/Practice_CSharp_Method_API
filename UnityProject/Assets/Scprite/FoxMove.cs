using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxMove : MonoBehaviour
{
	//狐狸的移動速度
	public float speed=10;
	//箱子的圖片渲染器
	public SpriteRenderer mySpriteR;
	//狐狸
	public Rigidbody2D fox;
	//速度修改器
    public float sp;

    public void Start()
	{
		mySpriteR = GetComponent<SpriteRenderer>();
		fox = GetComponent<Rigidbody2D>();
		mySpriteR= GameObject.Find("fox").GetComponent<SpriteRenderer>();
		fox = GameObject.Find("fox").GetComponent<Rigidbody2D>();
	}
	public void Move(float speed)
	{
		if(Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow))
		{
			sp = speed;
			speed = sp*Input.GetAxisRaw("Horizontal");
			mySpriteR.flipX = true;
			fox.AddForce(new Vector2(speed, 0));
			print("a or Left" + speed);
		}
		if(Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow))
        {
			sp = speed;
			speed = sp*Input.GetAxisRaw("Horizontal");
			mySpriteR.flipX = false;
			fox.AddForce(new Vector2(speed, 0));
			print("d or Right"+ speed);
		}
		
	}
		
	
	public void Update()
	{
	   Move(speed);
		print(Input.GetAxisRaw("Horizontal"));
		print(speed);

	}
}