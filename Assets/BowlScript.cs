using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlScript : MonoBehaviour {

    private Vector3 lastPos;

	// Use this for initialization
	void Start () {
        lastPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        lastPos = transform.position;
	}

    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.GetComponent<BallScript>())
    //    {
    //        foreach (ContactPoint contact in collision.contacts)
    //        {
    //            print(contact.thisCollider.name + " hit " + contact.otherCollider.name);
    //            Debug.DrawRay(contact.point, contact.normal, Color.white, 20, true);
    //            Debug.Log(contact.normal);

    //            Vector3 tempVect = lastPos - transform.position;

    //            contact.otherCollider.transform.GetComponent<Rigidbody>().AddForce(Vector3.Scale(-contact.normal, tempVect) * 20000, ForceMode.Acceleration);
    //        }

    //        //collision.transform.GetComponent<Rigidbody>().AddForce(collision.contact.normal);
    //    }
    //}
}
