using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lioghtflicker : MonoBehaviour
{
    public Light eggLight;
    float minIntens = 0.1f;
    float maxIntens = 0.6f;
    // Start is called before the first frame update
    void Start()
    {
        eggLight.GetComponent<Light>();
        StartCoroutine(lightupdate());
    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(lightupdate());
    }

    IEnumerator lightupdate()
    {
        eggLight.intensity = Random.Range(5000, 60000);
        yield return new WaitForSeconds(Random.Range(minIntens, maxIntens));
        eggLight.intensity = Random.Range(5000, 60000);
        yield return new WaitForSeconds(Random.Range(minIntens, maxIntens));
        eggLight.intensity = Random.Range(5000, 60000);
        yield return new WaitForSeconds(Random.Range(minIntens, maxIntens));
        eggLight.intensity = Random.Range(5000, 60000);
        yield return new WaitForSeconds(Random.Range(minIntens, maxIntens));
        StartCoroutine(lightupdate());
    }

    //Random.Range(minIntens, maxIntens)
}
