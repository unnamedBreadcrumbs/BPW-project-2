using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

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
    public float enableChrom = 0.2f;
    public bool overrideChrom = true;
    public AudioSource emergency;
    public AudioSource flikkerSound;
    public Animator Lever;


    // Start is called before the first frame update
    void Start()
    {
        Lever.GetComponent<Animator>();
        /*VolumeProfile posprofile = postPros.profile;
        if (!posprofile.TryGet<ChromaticAberration>(out var Chrom))
        {
            Chrom = postPros.Add<ChromaticAberration>(false);
        }*/
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
        /*VolumeProfile posprofile = postPros.profile;
        if (!posprofile.TryGet<ChromaticAberration>(out var Chrom))
        {
            Chrom = posprofile.Add<ChromaticAberration>(true);
            Debug.Log("chrom added?");
        }*/

        if (eDown == true && ePressed != true)
        {
            Lever.SetTrigger("Trigger");
            goFlicke = true;
            activeLamp.intensity = 60000;
            lampGoOff.sceneswitchon = true;
            doorOld.SetActive(false);
            doorNew.SetActive(true);
            AMONGUS.SetActive(true);
            ePressed = true;
            emergency.Play();

            VolumeProfile posprofile = postPros.profile;
            if (!posprofile.TryGet<ChromaticAberration>(out var Chrom))
            {
                Chrom = posprofile.Add<ChromaticAberration>(true);
            }
            Chrom.intensity.value = enableChrom;


            /*for (float i = 3; i >= 0; i -= Time.deltaTime)
            {
                Debug.Log(i);
                enableChrom = enableChrom + 0.01f;
                Chrom.intensity.value = enableChrom;
            }*/
            //Chrom.intensity.overrideState = overrideChrom;

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
        flikkerSound.Play();
        yield return new WaitForSeconds(1);
        flickerLamp.intensity = 6000;
        flikkerSound.Pause();
        yield return new WaitForSeconds(1);
        StartCoroutine(redflickr());
    }
}
