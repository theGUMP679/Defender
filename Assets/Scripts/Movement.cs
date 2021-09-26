using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;
    public Rigidbody2D characterRBx;

    void Start()
    {
        characterRBx = transform.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 charactermove = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += charactermove * Time.deltaTime * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float JumpForce = 5.0f;
            characterRBx.velocity = Vector2.up * JumpForce;
        }

    }
}
