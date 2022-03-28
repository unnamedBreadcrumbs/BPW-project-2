using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneswitch : MonoBehaviour
{
    public Light flickerLamp;
    public GameObject activeLamp;
    public bool eDown;
    bool goFlicke;
    public lampoff lampGoOff;
    public GameObject doorOld;
    public GameObject doorNew;
    public GameObject AMONGUS;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.E))
        {
            eDown = true;
        }
        else
        {
            eDown = false;
        }

        if (goFlicke == true)
        {
            StartCoroutine(redTimer());
            goFlicke = false;
        }
    }

    void OnTriggerStay (Collider other)
    {
        if (eDown == true)
        {
            goFlicke = true;
            activeLamp.SetActive(true);
            lampGoOff.sceneswitchon = true;
            doorOld.SetActive(false);
            doorNew.SetActive(true);
            AMONGUS.SetActive(true);
        }
    }

    IEnumerator redTimer()
    {
        yield return new WaitForSeconds(8);
        StartCoroutine(redflickr());
    }
    IEnumerator redflickr()
    {
        flickerLamp.intensity = 400000;
        yield return new WaitForSeconds(1);
        flickerLamp.intensity = 6000;
        yield return new WaitForSeconds(1);
        StartCoroutine(redflickr());
    }
}
