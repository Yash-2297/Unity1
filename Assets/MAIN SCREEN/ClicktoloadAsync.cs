using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClicktoloadAsync : MonoBehaviour {
        public Slider bar;
    public GameObject loadingImage;
    private AsyncOperation async;
    public int score=0, remain=40 ;

    public void clickAsync(int level)
    {
        loadingImage.SetActive(true);
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.SetInt("Remain", remain);
        StartCoroutine(LoadLevelWithBar(level));
    }

    IEnumerator LoadLevelWithBar(int level)
    {
        async = Application.LoadLevelAsync(level);
        while(!async.isDone)
        {
            bar.value = async.progress;
            yield return null;
        }
    }
        // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
