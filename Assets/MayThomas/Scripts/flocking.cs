using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flocking : MonoBehaviour {

	

	void Start () {
		
	}
	void Update () {

        Debug.Log(GetComponent<Rigidbody>().velocity);
	}

    void calcVelocity()
    {

    }
}
