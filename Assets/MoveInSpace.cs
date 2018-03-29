using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInSpace : MonoBehaviour {

    // public Text counttext;
    // public Text win;
    public Animator ani;
    private Quaternion targetRotation;
    private float speed = 15.0f;

    private Rigidbody rb;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

    private int count = 0;
    private int total = 10;
    private bool hasStarted = false;

    /*  void SetText()
      {

          if (total == 0 || count == 10)
          {
              win.text = "YOU FOUND EVERYTHING!!";
          }
          counttext.text = "Count: " + count.ToString() + " Remaining: " + total.ToString();

      }*/

    // Use this for initialization
    void Start()
    {

        Debug.Log(this.transform + "MOVE SCRIP:");
        ani = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        //ani.Play("idle");
        Debug.Log("runnibggggggg");
     //   SetText();

    }


    // Update is called once per frame
    void Update()
    {
        GameObject p = this.transform.gameObject;
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 15.0f;

            if (Input.GetKeyDown(KeyCode.DownArrow) || (hasStarted == true))
            {
            ani.Play("walk");
                p.transform.Translate(z, 0, 0);
                hasStarted = true;
            }

            if (Input.GetKey(KeyCode.RightArrow) || (hasStarted == true))
            {
            ani.Play("walk");
            transform.Rotate(0, x, 0);
                transform.Translate(transform.forward * 15.0f * Time.deltaTime);
                hasStarted = true;

            }


            if (Input.GetKey(KeyCode.LeftArrow) || (hasStarted == true))
            {
            ani.Play("walk");
            transform.Rotate(0, x, 0);
                transform.Translate(transform.forward * 15.0f * Time.deltaTime);
                hasStarted = true;

            }


            if (Input.GetKeyDown(KeyCode.UpArrow) || (hasStarted == true))
            {
            ani.Play("walk");
            transform.Translate(p.transform.forward * 15.0f * Time.deltaTime);
                hasStarted = true;
            }
      /*  
      if (Input.anyKey || hasStarted==true)
        {
            Debug.Log("LEY PRESEES!!!!");
           // ani.Play("run");
            p.transform.Rotate(0, x, 0);
            p.transform.Translate(0, 0, z);
            hasStarted = true;
        }*/

        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if (other.gameObject.CompareTag("PickUp"))
        {
            count = count + 1;
            ani.Play("pick-up");
            total = total - 1;
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
          //  SetText();
            audio.Play(44100); other.gameObject.SetActive(false);
        }

        else if (other.gameObject.CompareTag("change"))
        {
            ani.Play("pick-up");
            Application.LoadLevel(1);
        }

    }
}