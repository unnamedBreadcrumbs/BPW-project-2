using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door1 : MonoBehaviour
{
    bool ePress = false;
    public GameObject Door;
    public Transform DoorRot;
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
            //Debug.Log(ePress);
        }

        /*if (DoorRot.eulerAngles.y >= -90f && DoorRot.eulerAngles.y <= 95f)
        {
            ePress = false;
            Debug.Log("door done");
        }*/
    }

    void OnTriggerStay (Collider other)
    {
        if(ePress == true)
        {
            //Debug.Log("wahoo");
            Door.transform.Rotate(moveDirection * 0.01f);
        }
    }
}
