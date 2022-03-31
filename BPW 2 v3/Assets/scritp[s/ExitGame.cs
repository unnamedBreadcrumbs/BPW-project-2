using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    //public bool ExitGameBool;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (ExitGameBool == true)
        {
            Application.Quit();
        }*/
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
