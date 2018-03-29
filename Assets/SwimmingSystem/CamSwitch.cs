using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour {
   
    public Camera[] cam;
  
    // Use this for initialization
    void Start () {
        cam[1].enabled = false;
        cam[0].enabled = true;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (cam[0].enabled == true)
            {
                cam[1].enabled = true;

                 cam[0].enabled = false;
              //  g.SetActive(true);

            }

            else if (cam[1].enabled == true)

            {
              //  g.SetActive(false);
                cam[1].enabled = false;
                cam[0].enabled = true;

            }
        }
    }
    
}
