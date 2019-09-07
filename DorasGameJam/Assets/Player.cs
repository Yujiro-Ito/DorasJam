using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    Vector2 startPos;
    //Vector2 m_moveLimit = new Vector2(2.7f, 4.4f);

    float speed = 500.0f;
    int move = 0;
    int sceneMove = 0;

    void Start()
    {
        this.rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0) && move == 0)
        {
            this.startPos = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0) && move == 0)
        {
            move += 1;
            Vector2 endPos = Input.mousePosition;
            Vector2 startDirection = -1 * (endPos - startPos).normalized;
            this.rigidbody2d.AddForce(startDirection * speed);
            Debug.Log(speed);
        }

        float currentSpeed = Vector2.SqrMagnitude(rigidbody2d.velocity);

        if (currentSpeed > 0 && currentSpeed < 2.0f 
            && move == 1 && sceneMove == 0)
        {
            Debug.Log(currentSpeed);
            SceneManager.LoadScene("Result", LoadSceneMode.Additive);
            sceneMove += 1 ;
        }
    }

    private void FixedUpdate()
    {
        this.rigidbody2d.velocity *= 0.995f;
    }
}
