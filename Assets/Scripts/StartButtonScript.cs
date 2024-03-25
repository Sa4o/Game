using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    public string LoadScene = "";

    public void onClick()
    {
        SceneManager.LoadScene(LoadScene, LoadSceneMode.Single);
    }
}
