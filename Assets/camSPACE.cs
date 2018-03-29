using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camSPACE : MonoBehaviour {

    // Use this for initialization

    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        //  Camera c = GameObject.Find("MaleFreeSimpleMovement1").GetComponent<Camera>();

        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;



    }
}