using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLifeTime : MonoBehaviour
{
    public float lifeTime = 5f;
    private GameObject gearObject;

    // Update is called once per frame
    void Update()
    {
        if(lifeTime > 0)
        {
            lifeTime -= Time.deltaTime;
            if (lifeTime <= 0)
            {
                DestroyObject();
            }
        }
    }


    void DestroyObject()
    {
        //Destroy(instance.gameObject);
    }
}
