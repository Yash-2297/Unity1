using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{

    public float rs;
    public float xAngle;
    public float zAngle;
    public float zs;
    public float zDist;
    private Transform cam;

    public GameObject player;

    private Vector3 offset;

   
    

  
    void Start()
    {
 // player = GameObject.Find("MobileMaleFreeSimpleMovement1");



    cam = this.transform.Find("Main Camera");
        Debug.Log(cam);
          offset = cam.transform.position - player.transform.position;    
        rs = 100;

        zs = 100;
        xAngle = cam.transform.eulerAngles.x;

        zDist = cam.localPosition.z;
        Debug.Log(zDist);

        Debug.Log(cam);
    }

   void LateUpdate()
    {
       cam.transform.position = player.transform.position + offset;
    }
    void Update()
    {
        float rotY = Input.GetAxis("Mouse X");
        float rotX = Input.GetAxis("Mouse Y");
        float zoom = Input.GetAxis("Mouse ScrollWheel");

      //  cam.transform.Rotate(0, rotY * Time.deltaTime * rs, 0, Space.World);
        //cam.transform.Rotate(rotX*Time.deltaTime*rs,0,0,Space.Self);

        xAngle += rotX * rs * Time.deltaTime;
        zDist = zoom * zs * Time.deltaTime; //for zoom

        //limit Rotation
        //NOT GOOD WAY

        Vector3 currentRot = cam.transform.eulerAngles;
        Debug.Log(currentRot);

        if (currentRot.x > 70)
        {
            currentRot.x = 70;
            cam.transform.eulerAngles = currentRot;
        }

        xAngle = Mathf.Clamp(xAngle, -20, 0);
        Debug.Log(xAngle);
        Vector3 angles = cam.transform.eulerAngles;
        angles.x = xAngle;

        cam.transform.eulerAngles = angles;

        //CAMERA ZOOM 
        zDist = Mathf.Clamp(zAngle, -5, 5);
     //  cam.transform.localPosition = new Vector3(0, 0, zDist);


    }
}