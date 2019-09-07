using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    private void Start()
    {
        SoundPlayer.Instance.StopAllBGM();
    }

    public void PushEndButton()
    {
        OnApplicationQuit();
    }

    public void PushStartButton()
    {
        SceneManager.LoadScene("Stage1");
    }

    void OnApplicationQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
   Application.Quit();
#endif
    }

}
