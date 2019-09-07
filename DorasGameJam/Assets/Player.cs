using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    Vector2 startPos;
    //Vector2 m_moveLimit = new Vector2(2.7f, 4.4f);


    float speed = 500.0f;
    void Start()
    {
        this.rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            Vector2 startDirection = -1 * (endPos - startPos).normalized;
            this.rigidbody2d.AddForce(startDirection * speed);
            Debug.Log(speed);
        }
    }

    private void FixedUpdate()
    {
        this.rigidbody2d.velocity *= 0.995f;
    }
}
