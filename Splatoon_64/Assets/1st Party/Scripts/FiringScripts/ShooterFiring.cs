using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterFiring : MonoBehaviour 
{
    [SerializeField] Rigidbody paintPrefab;
    [SerializeField] float speed;
    [SerializeField] float falloffSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1"))
            Fire();
            
       
	}

    void Fire()
    {
        Rigidbody paintInstance;
        paintInstance = Instantiate(paintPrefab, transform.position, transform.rotation) as Rigidbody;

        paintInstance.AddForce(transform.forward * speed, ForceMode.Impulse);
        paintInstance.AddForce(-transform.up * falloffSpeed);

    }
}
