using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        Ray ray = new Ray(gameObject.transform.position, gameObject.GetComponent<Rigidbody>().velocity);
        if (Physics.Raycast(ray, out hit))
        {
            //gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
            
	}
}
