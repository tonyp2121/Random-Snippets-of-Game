using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour {

    void Start()
    {
        Invoke("initialLevelLoad", 4);
    }
    void initialLevelLoad()
    {
        SceneManager.LoadScene(1);
    }
}
