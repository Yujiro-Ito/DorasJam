using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
    public void OnPressNext()
    {
        string nextSceneName = Application.Instance.GameMain.NextSceneName;
        SceneManager.LoadScene(nextSceneName);
    }

    public void OnPressFinish()
    {
        SceneManager.LoadScene("Title");
    }
}
