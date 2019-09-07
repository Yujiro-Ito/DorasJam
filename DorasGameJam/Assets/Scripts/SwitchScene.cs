using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    [SerializeField] string _stageName;
    public void OnResult()
    {
        SceneManager.LoadScene(_stageName, LoadSceneMode.Additive);
    }
}
