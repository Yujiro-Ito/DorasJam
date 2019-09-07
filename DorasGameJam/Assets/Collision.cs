using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collision : MonoBehaviour
{
    Coroutine _switchScene;

    // Start is called before the first frame update
    void Start()
    {
        _switchScene = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject.FindObjectOfType<SwitchScene>().OnResult();
    }
}
