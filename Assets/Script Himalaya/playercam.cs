using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercam : MonoBehaviour {
    private Vector3 offset;

    // Use this for initialization
    void Start () {
        Debug.Log(this.transform + "playcam" +  this.transform.parent);
        offset = this.transform.position - this.transform.parent.position;



    }
    void LateUpdate()
    {
        this.transform.position = this.transform.parent.position + offset;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
