using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Move : MonoBehaviour
{
    public  Animator ani;


    private Quaternion targetRotation;
    private float speed = 2f;

    private Rigidbody rb;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

    private int count = 0;
    private int total = 10;

 

    // Use this for initialization
    void Start()
    {

    Debug.Log(this.transform + "MOVE SCRIP:" );
        ani = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        ani.Play("idle");
        Debug.Log("runnibggggggg");
      
       
    }


    // Update is called once per frame
    void Update()
    {
        GameObject p = this.transform.gameObject;
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 15.0f;
        if (Input.GetKey(KeyCode.Space))
        {
            ani.Play("jump");
           
            p.transform.Translate(0f, 6f*Time.deltaTime,2.0f*Time.deltaTime);
        }

        
       else if (Input.anyKey) { 
       
        ani.Play("run");
        p.transform.Rotate(0, x, 0);
        p.transform.Translate(0, 0, z); }

        else
        {
            ani.Play("idle");


        }
    }
   

}
   