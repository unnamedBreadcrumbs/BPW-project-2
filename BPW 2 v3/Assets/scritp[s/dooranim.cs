using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooranim : MonoBehaviour
{
    public Animator Door;
    bool ePress = false;
    public bool Collided;
    public AudioSource Creaky;
    public GameEnder GameEnd;

    // Start is called before the first frame update
    void Start()
    {
        Door.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("e"))
        {
            ePress = true;
        } else
        {
            ePress = false;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (ePress == true && !Collided)
        {
            Collided = true;
            Debug.Log("fuck");
            Door.SetTrigger("activate");
            Creaky.Play();
            GameEnd.GameEnd = true;
        }
    }
}
