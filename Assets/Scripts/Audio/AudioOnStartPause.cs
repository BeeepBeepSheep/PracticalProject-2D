using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AusioPauseOnStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioBetweenScenes.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }
}


