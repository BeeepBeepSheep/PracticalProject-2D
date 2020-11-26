using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCurrant : MonoBehaviour
{
    //void LoadCurrantScene()
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Debug.Log("Reloaded");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
