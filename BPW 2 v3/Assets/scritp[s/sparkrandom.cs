using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sparkrandom : MonoBehaviour
{
    public ParticleSystem sparky;
    int minIntens = 3;
    int maxIntens = 25;
    // Start is called before the first frame update
    void Start()
    {
        sparky.GetComponent<ParticleSystem>();
        StartCoroutine(sparkUpdate());
    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(lightupdate());
    }

    IEnumerator sparkUpdate()
    {
        sparky.Play();
        yield return new WaitForSeconds(Random.Range(minIntens, maxIntens));
        sparky.Play();
        yield return new WaitForSeconds(Random.Range(minIntens, maxIntens));
        StartCoroutine(sparkUpdate());
    }

    //Random.Range(minIntens, maxIntens)
}
