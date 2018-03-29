using UnityEngine;
using UnityEngine.UI;

using System.Collections;


public class GameController : MonoBehaviour
{
    public GameObject hazard;
    public GameObject collect;
    public Vector3 spawnValues;
    public int hazardCount;
    public int collectCount;
    public int count;
    public GameObject UAV;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public Text ss;
    public Text rr;




    void Start()
    {
       
      //  SetText();
        StartCoroutine(SpawnWaves());
    }

   public void changeCount()
    {
        count = 0;
    }
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (count>0)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }

            for (int i = 0; i < collectCount; i++)
            {
                Debug.Log("Collector");
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(collect, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }

            count++;

            yield return new WaitForSeconds(waveWait);
        }
    }
}