using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI    ;


public class DestroyOnTouch : MonoBehaviour {

    public Slider bar;
    
    public GameObject loadingImage;
    private AsyncOperation async;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("UAV"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            clickAsync(0);
        }
        
    }



    public void clickAsync(int level)
    {
        loadingImage.SetActive(true);
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

    void Start()
    {
  

    }
}
