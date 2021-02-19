using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildOnCollision : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Collectable"))
        {
            ContactPoint contact = collision.contacts[0];
            Vector3 pos = contact.point;
            GameObject ob = collision.gameObject;
            ob.transform.parent = gameObject.transform;
            ob.transform.position = pos;
            ob.GetComponent<Collider>().enabled = false;
            //collision.gameObject.transform.localPosition
        }
    }
}
