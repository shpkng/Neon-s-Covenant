using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour {


    public Transform player1;


    [SerializeField]

    Vector3 playerToLook;



    private void Awake()
    {
        playerToLook = this.transform.position - player1.transform.position;
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        this.transform.position = player1.transform.position + playerToLook;
		
	}
}
