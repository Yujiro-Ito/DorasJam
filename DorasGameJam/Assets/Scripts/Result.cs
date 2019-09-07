using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
    public void OnPressNext()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void OnPressFinish()
    {
        SceneManager.LoadScene("Title");
    }
}
