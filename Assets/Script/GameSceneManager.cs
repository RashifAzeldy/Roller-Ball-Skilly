using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            DontDestroyOnLoad(this);
            SceneManager.LoadScene("GameplayScene");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            DontDestroyOnLoad(this);
            SceneManager.LoadScene("RandomScene");
        }
    }
}
