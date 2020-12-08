using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBetweenScenes : MonoBehaviour
{
    private static AudioBetweenScenes instance = null;
    public static AudioBetweenScenes Instance
    {
        get
        {
            return instance;
        }
    }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
