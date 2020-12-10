using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCurrant : MonoBehaviour
{
    //void LoadCurrantScene()
    void Update()
    {
        //reload currant level
        if (Input.GetKey(KeyCode.R))
        {
            Debug.Log("Reloaded");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        } // return to menu
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }
    public void reload()
    { // reload for button
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void menu()
    { // back to menu for button
        SceneManager.LoadScene("Menu");
    }
}
