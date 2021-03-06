﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRadar : MonoBehaviour
{

	public Transform AimedEnemy { get; set; }
	private Transform player;

	// Use this for initialization
	void Start()
	{
		player = GameObject.Find("ThirdPersonController").GetComponent<Transform>();
		//AimedEnemy = GameObject.Find("ImOnlyASphere").GetComponent<Transform>();
	}

	// Update is called once per frame
	void Update()
	{

		//如果目标敌人存活
		if (AimedEnemy)
		{
		//这里是用来处理雷达刷新的代码
			Vector3 offset = AimedEnemy.position - player.position;
			this.transform.localPosition = (player.transform.position +  offset.normalized);
			//this.transform.Rotate(offSet.normalized);
		}
		else
		{
			Destroy();
		}
	}


	//播放指示器消失的动画
	void Destroy()
	{
		
	}
}
