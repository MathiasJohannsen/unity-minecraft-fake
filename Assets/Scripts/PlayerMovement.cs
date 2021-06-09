using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float PlayerSpeed = 12f;
    public float Gravity = -9.81f;
    public float JumpHeight = 3f;

    public Transform GroundCheck;
    public float GroundDistance = 0.4f;
    public LayerMask GroundMask;
    bool IsGrounded;

    public CharacterController Controller;
    Vector3 Velocity;

    void Update()
    {
        IsGrounded = Physics.CheckSphere(GroundCheck.position, GroundDistance, GroundMask);
        if (IsGrounded && Velocity.y < 0)
        {
            Velocity.y = -2f;
        }

        if (Input.GetButton("Jump") && IsGrounded)
        {
            Velocity.y = Mathf.Sqrt(JumpHeight * -2 * Gravity);
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        Controller.Move(move * PlayerSpeed * Time.deltaTime);

        Velocity.y += Gravity * Time.deltaTime;
        Controller.Move(Velocity * Time.deltaTime);
    }
}
