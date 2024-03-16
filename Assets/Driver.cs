using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float fastSpeed = 30f;

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float directionAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, directionAmount, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Speed Up")
        {
            Debug.Log("Speed up!");
            moveSpeed = fastSpeed;
        }
        if(other.tag == "Speed Down")
        {
            Debug.Log("Speed down!");
            moveSpeed = slowSpeed;
        }
    }
}

