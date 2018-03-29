
using UnityEngine;
using System.Collections;

public class UpperCamera : MonoBehaviour
{

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