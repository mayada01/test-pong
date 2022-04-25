using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{

    public string sceneToLoad;

    public void LoadNextScene()
    {
        
        SceneManager.LoadScene(sceneToLoad);
        destroyBrick.numOfDestroyedBricks = 0;
    }
}
