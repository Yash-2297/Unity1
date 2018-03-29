using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreSet : MonoBehaviour {

    public Text ss;
    public Text rr;
    public int temp;
    private AsyncOperation async;
    public Slider bar;
    public GameObject loadingImage;
    public GameObject Cube;
    public GameObject a;
    public int score;
    public int remain;


    public void clickAsync(int level)
    {
        loadingImage.SetActive(true);
        PlayerPrefs.SetInt("Score",score);
        PlayerPrefs.SetInt("Remain", remain);
        StartCoroutine(LoadLevelWithBar(level));
    }

    IEnumerator LoadLevelWithBar(int level)
    {
        async = Application.LoadLevelAsync(level);
        while (!async.isDone)
        {
            bar.value = async.progress;
            yield return null;
        }
    }

    void SetText()
    {

        if (remain == 0 )
        {
            Application.LoadLevel(5);
        }
        if (temp == 10)
        {
            a.SendMessage("changeCount");
            whenDone();
        }
        ss.text = "Score: " + score.ToString();
        rr.text="Remaining: " + remain.ToString();

    }
    void OnTriggerEnter(Collider other)
    { Debug.Log(other);
        if (other.gameObject.CompareTag("PickUp"))
        {
            score = score + 1;
            remain =remain - 1;
            temp++;
            
            SetText();
        }

        if (other.gameObject.CompareTag("Forest"))
        {
            clickAsync(3);
        }
        if (other.gameObject.CompareTag("Water"))
        {
            clickAsync(4);
        }
        if (other.gameObject.CompareTag("Mountains"))
        {
            clickAsync(1);
        }
       

    }

    public void whenDone()
    {

        Cube.SetActive(true);



    }
    // Use this for initialization
    void Start () {
        a= GameObject.FindWithTag("Controller");
        score = PlayerPrefs.GetInt("Score", 0);
        remain = PlayerPrefs.GetInt("Remain", 40);
        SetText();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
