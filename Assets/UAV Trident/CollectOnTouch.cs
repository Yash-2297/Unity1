using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectOnTouch : MonoBehaviour {


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("UAV"))
        {
            Destroy(gameObject);
            
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
