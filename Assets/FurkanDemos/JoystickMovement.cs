using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class JoystickMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private FixedJoystick joystick;
    private Vector3 input;
    private Rigidbody rb;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody> ();    
    }

    private void Update()
    {
        input.x = joystick.Horizontal;
        input.z = joystick.Vertical;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + transform.TransformDirection(input*speed*Time.deltaTime)); 
    }
}
