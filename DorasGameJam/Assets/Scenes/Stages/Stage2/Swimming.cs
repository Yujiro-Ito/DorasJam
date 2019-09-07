using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swimming : MonoBehaviour
{
    Vector3 vec;
    public float first;
    // Start is called before the first frame update
    void Start()
    {
        vec.x = first;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= vec * Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        float y = 180;
        this.transform.Rotate(0.0f, y, 0.0f);
        vec.x *= -1;
    }
}
