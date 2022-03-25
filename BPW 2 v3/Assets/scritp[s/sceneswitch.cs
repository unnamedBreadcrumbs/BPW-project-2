using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneswitch : MonoBehaviour
{
    public GameObject blockAppear;
    bool eDown;
    // Start is called before the first frame update
    void Start()
    {
        blockAppear.SetActive(false);
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
    }

    void OnTriggerStay (Collider other)
    {
        if (eDown == true)
        {
            blockAppear.SetActive(true);
        }
    }
}
