using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public void LoadGame1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //---------------------------------------

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void LoadLevel4()
    {
        SceneManager.LoadScene("Level4");
    }
    public void LoadLevel5()
    {
        SceneManager.LoadScene("Level5");
    }
    public void LoadLevel6()
    {
        SceneManager.LoadScene("Level6");
    }
    public void LoadLevel7()
    {
        SceneManager.LoadScene("Level7");
    }
    public void LoadLevel8()
    {
        SceneManager.LoadScene("Level8");
    }
    public void LoadLevel9()
    {
        SceneManager.LoadScene("Level9");
    }
    public void LoadLevel10()
    {
        SceneManager.LoadScene("Level10");
    }
    public void LoadLevel11()
    {
        SceneManager.LoadScene("Level11");
    }
    //public void LoadLevel()
    //{
    //    SceneManager.LoadScene("Level");
    //}


    //-----------------------------------------------
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
