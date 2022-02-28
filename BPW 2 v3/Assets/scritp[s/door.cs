using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    bool ePress = false;
    public GameObject Door;
    public Vector3 moveDirection;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("e"))
        {
            ePress = true;
            Debug.Log(ePress);
        } /*else
        {
            ePress = false;
        }*/
    }

    void OnTriggerStay (Collider other)
    {
        if(ePress == true)
        {
            Debug.Log("wahoo");
            Door.transform.position += moveDirection * 0.01f;
        }
    }
}
