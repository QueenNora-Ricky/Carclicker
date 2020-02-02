using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHover : MonoBehaviour
{
    private int gearNum = 0;
    public GameObject gearObject;
    private GameObject gearClone;

    // Start is called before the first frame update
    void Start()
    {
        gearClone = gearObject;
    }

    // Update is called once per frame
    void Update()
    {
        //OnTriggerEnter(gearClone.GetComponent<Collider>());
        gameObject.transform.Translate(-0.075f,0,0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (Input.GetMouseButtonDown(0))
        {
            gearNum++;
            Destroy(gearClone);
        }
    }
}
