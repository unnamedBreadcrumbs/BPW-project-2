using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampoff : MonoBehaviour
{
    public bool sceneswitchon = false;
    public GameObject lampoffPrefab1;
    public GameObject lampoffPrefab2;
    public GameObject lampoffPrefab3;
    public GameObject lampoffPrefab4;
    public GameObject lampoffPrefab5;
    public GameObject lampoffPrefab6;
    public GameObject lampoffPrefab7;
    public GameObject lampoffPrefab8;
    public GameObject lampoffPrefab9;
    public GameObject lampoffPrefab10;
    public GameObject lampoffPrefab11;
    public GameObject lampoffPrefab12;
    public GameObject lampoffPrefab13;
    public GameObject lampoffPrefab14;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(sceneswitchon == true)
        {
            StartCoroutine(lampSequence());
        }
    }

    IEnumerator lampSequence()
    {
        lampoffPrefab1.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        lampoffPrefab2.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        lampoffPrefab3.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        lampoffPrefab4.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        lampoffPrefab5.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        lampoffPrefab6.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        lampoffPrefab7.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        lampoffPrefab8.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        lampoffPrefab9.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        lampoffPrefab10.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        lampoffPrefab11.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        lampoffPrefab12.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        lampoffPrefab13.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        lampoffPrefab14.SetActive(false);
        yield return new WaitForSeconds(0.5f);

    }
}
