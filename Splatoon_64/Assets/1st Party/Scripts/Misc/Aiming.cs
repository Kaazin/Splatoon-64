using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour {

    float currentX;
    float currentY;

    [SerializeField] float min;
    [SerializeField] float max;
    [SerializeField] Transform player;

	// Use this for initialization
	void Start () 
    {
        Cursor.lockState = CursorLockMode.Locked;
        player = transform.parent.root;
	}
	
	// Update is called once per frame
	void Update () {
        currentX += Input.GetAxis("Mouse X");
        currentY += Input.GetAxis("Mouse Y");
        currentY = Mathf.Clamp(currentY, min, max);

        Quaternion rotation = Quaternion.AngleAxis(-currentY, Vector3.right);

        player.rotation = Quaternion.AngleAxis(currentX, player.up);
        transform.localRotation = rotation;



	}
}
