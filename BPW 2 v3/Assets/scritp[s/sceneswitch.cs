using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneswitch : MonoBehaviour
{
    public GameObject blockAppear;
    // Start is called before the first frame update
    void Start()
    {
        blockAppear.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay (Collider other)
    {
        blockAppear.SetActive(true);
    }
}
