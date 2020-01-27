using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exitscript : MonoBehaviour
{
    private int nextSceneToLoad;

    void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player") 
        {
            SceneManager.LoadScene(nextSceneToLoad);
        }
    }
}
