using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mausu : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        var vec = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow)) vec.y += 1.0f;
        if (Input.GetKey(KeyCode.DownArrow)) vec.y -= 1.0f;
        if (Input.GetKey(KeyCode.RightArrow)) vec.x += 1.0f;
        if (Input.GetKey(KeyCode.LeftArrow)) vec.x -= 1.0f;

        vec = vec.normalized;
        transform.position += vec ;

    }
}
