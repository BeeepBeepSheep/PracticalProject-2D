using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManegement;
public class SceneTransition : MonoBehaviour
{
    private int nextSceneToLoad;
    void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    void OnTriggerEnter2D(Colldier2D collision)
    {
        SceneManager.LoadScene(nextSceneToLoad);
    }
}
