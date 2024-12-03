using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public FixedJoystick joystick; // Joystick referans�
    public float moveSpeed = 5f; // Hareket h�z�
    public float rotationSpeed = 10f; // D�n�� h�z�


    void Update()
    {
        // Joystick y�n vekt�r�n� al
        Vector2 input = new Vector2(joystick.Horizontal, joystick.Vertical);

        // E�er joystick hareket etmiyorsa ��k
        if (input.magnitude < 0.1f) return;

        // Hareket i�lemi
        Vector3 moveDirection = new Vector3(input.x, 0, input.y).normalized;
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        // D�nme i�lemi
        Quaternion toRotation = Quaternion.LookRotation(moveDirection, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
    }
}
