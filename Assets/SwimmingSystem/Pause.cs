using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour
{

    public GameObject pauseScreen;

    public void PauseIt()
    {
        Time.timeScale = 0;
        pauseScreen.SetActive(true);
        //Disable scripts that still work while timescale is set to 0
    }
    public void UnPauseIt()
    {
        Debug.Log("DONENDODED");
        pauseScreen.SetActive(false);

        Time.timeScale = 1;
        //enable the scripts again
    }

    void Start()
    {
        //pausePanel.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
                 PauseIt();
          
         
        }
        if(Input.GetKeyDown(KeyCode.B))
        {
           UnPauseIt();


        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            GetComponent<AudioSource>().mute = true;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            GetComponent<AudioSource>().mute = false;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Application.LoadLevel(0);
;
        }
    }

}