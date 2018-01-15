using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{

	public GameController gameController;
	public string typeOfThisObject;


	/// <summary>
	/// 按E可赛艇
	/// </summary>
	public void E()
	{
		switch (typeOfThisObject)
		{
			case "Portal": Portal(); break;
			case "Else":Else() ; break;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		gameController.InteractableObject = this;
	}

	void Portal()
	{;
		Debug.Log("Portal");
	}

	void Else()
	{
		Debug.Log("Else");
	}

}
