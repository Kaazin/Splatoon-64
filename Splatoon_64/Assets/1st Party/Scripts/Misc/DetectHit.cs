using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectHit : MonoBehaviour {

    [SerializeField] GameObject Inkblot;
    [SerializeField] Vector3 inkblotOffset;
    void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "Surface")
        {
            Instantiate(Inkblot, col.contacts[0].point + inkblotOffset ,col.transform.rotation);
            Destroy(gameObject);

        }

        if(col.transform.tag == "Destructable")
        {
            Debug.Log("Hit Destructable"); 
        }

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "Character")
        {
            Debug.Log("Hit Character");
        }
    }
}
