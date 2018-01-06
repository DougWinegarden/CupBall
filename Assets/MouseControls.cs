using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControls : MonoBehaviour
{

    public GameObject bowl;

    // Use this for initialization
    void Start()
    {
        Vector3 startPos = bowl.transform.position;
        startPos.z = 1;
        bowl.transform.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        //var touch = Input.touches[0];


        //if(touch == null)
        //{
        //    Debug.Log("ah shit");
        //}


        //if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved)
        //{
        //    // Construct a ray from the current touch coordinates
        //    var ray = Camera.main.ScreenPointToRay(touch.position);
        //    if (Physics.Raycast(ray))
        //    {
        //        // Create a particle if hit
        //        //Instantiate(particle, transform.position, transform.rotation);
        //        bowl.transform.position = touch.position;
        //    }
        //}
        Debug.Log(Input.mousePosition);


        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            //Debug.Log(Input.mousePosition);
            Vector3 bowlPos = hit.point;

            //bowlPos.x = bowlPos.x / Camera.main.pixelWidth;
            //bowlPos.y = bowlPos.y / Camera.main.pixelHeight;

            //bowlPos.x = bowlPos.x / Screen.width;
            //bowlPos.y = bowlPos.y / Screen.height;

            bowlPos.z = 1;

            //bowl.transform.position = bowlPos;


            bowl.transform.position = Vector3.Slerp(bowlPos, bowl.transform.position, 0.25f);
            //Transform objectHit = hit.transform;

            //Vector3 tempVect = bowlPos - bowl.transform.position;
            //bowl.transform.GetComponent<Rigidbody>().AddForce(tempVect * 5, ForceMode.Acceleration);

            // Do something with the object that was hit by the raycast.
        }

        //bowl.transform.position = Input.mousePosition;
    }
}
