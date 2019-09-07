using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swimming : MonoBehaviour
{
    GameObject _swimming1;
    GameObject _swimming2;
    // Start is called before the first frame update
    void Start()
    {
        _swimming1 = GameObject.Find("Swimming1");
        _swimming2 = GameObject.Find("Swimming2");

    }

    // Update is called once per frame
    void Update()
    {
        var vec = Vector3.zero;
        var vec2 = Vector3.zero;
        vec.x = 1;
        vec2.x = 1;
        _swimming1.transform.position += vec * Time.deltaTime; 
        _swimming2.transform.position -= vec2 * Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
