using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class sceneswitch : MonoBehaviour
{
    public Light flickerLamp;
    public Light activeLamp;
    public bool eDown = false;
    bool ePressed;
    bool goFlicke;
    public lampoff lampGoOff;
    public GameObject doorOld;
    public GameObject doorNew;
    public GameObject AMONGUS;
    public Volume postPros;

    // Start is called before the first frame update
    void Start()
    {
        VolumeProfile fuck = postPros.profile;
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
        if (eDown == true && ePressed != true)
        {
            goFlicke = true;
            activeLamp.intensity = 60000;
            lampGoOff.sceneswitchon = true;
            doorOld.SetActive(false);
            doorNew.SetActive(true);
            AMONGUS.SetActive(true);
            ePressed = true;

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
