using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnder : MonoBehaviour
{
    public bool GameEnd = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameEnd == true)
        {
            StartCoroutine(GameEndTime());
        }
    }

    IEnumerator GameEndTime()
    {
        yield return new WaitForSeconds(10);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene("Final Scene 2");
    }
}
