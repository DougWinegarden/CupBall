using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour {

    public GameObject bowl;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var touch = Input.touches[0];


        //if(touch == null)
        //{
        //    Debug.Log("ah shit");
        //}


        if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved)
        {
            // Construct a ray from the current touch coordinates
            var ray = Camera.main.ScreenPointToRay(touch.position);
            if (Physics.Raycast(ray))
            {
                // Create a particle if hit
                //Instantiate(particle, transform.position, transform.rotation);
                bowl.transform.position = touch.position;
            }
        }
    }
}
