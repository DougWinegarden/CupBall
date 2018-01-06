using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaceIt : MonoBehaviour {

    public GameObject bowl;

    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            Vector3 bowlPos = hit.point;
            bowlPos.z = 1;
            Vector3 tempVect = bowlPos - bowl.transform.position;
            bowl.transform.GetComponent<Rigidbody>().AddForce(tempVect * 5);
        }
    }
}
