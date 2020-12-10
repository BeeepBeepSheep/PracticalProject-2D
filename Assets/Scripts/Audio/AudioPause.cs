using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AudioPause : MonoBehaviour
{


    public void OnClickPause()
    {
        AudioBetweenScenes.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }
    public void OnClickPlay()
    {
        AudioBetweenScenes.Instance.gameObject.GetComponent<AudioSource>().Play();
    }
    public void isSceneMenu()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            AudioBetweenScenes.Instance.gameObject.GetComponent<AudioSource>().Pause();
        }

        else
        {
            AudioBetweenScenes.Instance.gameObject.GetComponent<AudioSource>().Play();
        }




    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            AudioBetweenScenes.Instance.gameObject.GetComponent<AudioSource>().Pause();
        }
    }
}


