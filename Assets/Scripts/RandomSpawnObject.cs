using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnObject : MonoBehaviour
{
    //private int objectLimit = 10;
    //This is used for the Object spawner
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;
    public Vector3 spawnValues;
    public Vector3 centre;

    //Object
    public GameObject gearObject;
    private GameObject gearClone;
    //private int gearNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
        
        //gearNum++;
        //Destroy(gearClone);
        //Destroy(gearObject, lifeTime);
        //MoveBack();
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)
        {
            Vector3 spawnPosition = centre + new Vector3(Random.Range(-spawnValues.x / 2, spawnValues.x / 2), Random.Range(-spawnValues.y / 2, spawnValues.y / 2), 0);

            gearClone = Instantiate(gearObject, spawnPosition, gearObject.transform.rotation);
            Destroy(gearClone.gameObject, 5f);
            yield return new WaitForSeconds(spawnWait);
        }
    }
}
