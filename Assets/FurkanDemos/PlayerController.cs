using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public FixedJoystick joystick; // Joystick referansý
    public float moveSpeed = 5f; // Hareket hýzý
    public float rotationSpeed = 10f; // Dönüþ hýzý


    void Update()
    {
        // Joystick yön vektörünü al
        Vector2 input = new Vector2(joystick.Horizontal, joystick.Vertical);

        // Eðer joystick hareket etmiyorsa çýk
        if (input.magnitude < 0.1f) return;

        // Hareket iþlemi
        Vector3 moveDirection = new Vector3(input.x, 0, input.y).normalized;
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        // Dönme iþlemi
        Quaternion toRotation = Quaternion.LookRotation(moveDirection, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
    }
}
