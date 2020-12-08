using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AudioPause : MonoBehaviour
{
    // Start is called before the first frame update

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
        if (SceneManager.GetActiveScene().buildIndex == "Menu")
        {
            AudioBetweenScenes.Instance.gameObject.GetComponent<AudioSource>().Pause();
        }
    }

}


