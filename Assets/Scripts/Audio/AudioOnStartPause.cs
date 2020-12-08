using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AusioPauseOnStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioBetweenScenes.Instance.gameObject.GetComponent<AudioSource>().Pause();

    }
}


