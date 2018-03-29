//ALWAYS USE THIS SCRIPT with GAMEOBJECT which consist CAMERA

//PROJECT SETTING->INPUT SETTING

using System.Collections;
using UnityEngine;

public class ZoomandFocus : MonoBehaviour
{
    int zoom = 20;
    int normal = 60;
    float smooth = 5;

    bool isZoom = false;

    private void Update()
    {
        if(Input.GetAxis("Mouse ScrollWheel")<0)
        {
            isZoom = !isZoom;
        }
        else
        {
            isZoom = isZoom;
        }
        if (isZoom)
        {
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, 100, Time.deltaTime * smooth);

        }
      /*  else
        {
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, normal, Time.deltaTime * smooth);

        }*/
    }
    /*
        if(Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y - 6f, transform.position.z + .2f);
            transform.Translate(-2, 0, 0);

        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y +.6f, transform.position.z -.2f);
            transform.Translate(2, 0, 0);
        }
    }*/
}

