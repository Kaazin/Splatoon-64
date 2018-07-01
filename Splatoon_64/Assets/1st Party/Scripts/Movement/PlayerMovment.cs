using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour {

    Rigidbody rb;

    float speed;
    [SerializeField] float runSpeed;
    [SerializeField] float swimSpeed;

	// Use this for initialization
	void Awake () 
    {
        rb = GetComponent<Rigidbody>();
        speed = runSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
