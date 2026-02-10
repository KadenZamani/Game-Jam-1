using UnityEngine;
using System.Collections;
//using System.Collections.Generic;
//using UnityEngine.Rendering;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;

    [SerializeField]
    private float mouseSensitivity = 2f;

    [SerializeField]
    private float jumpForce = 3f;

    private Vector3 moveDirection;
    private Vector3 jump;
    private float rotationY;

    public bool isGrounded;
    Rigidbody rb;

    [SerializeField]
    private AudioSource jumpSound;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0f, jumpForce, 0f);
        jumpSound = GetComponent<AudioSource>();
    }

    private void OnCollisionStay()
    {
        isGrounded = true;
    }

    private void Update()
    {
        HandleMovement();

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            jumpSound.Play();
            
        }
    }

    private void HandleMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        moveDirection = new Vector3(horizontal, 0f, vertical).normalized;

        rb.linearVelocity = new Vector3(moveDirection.x * speed, rb.linearVelocity.y, moveDirection.z * speed);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.contacts[0].normal.y > 0.5f)
            isGrounded = true;
    }



    private void HandleRotation()
    {
        float mouseX = Input.GetAxis("Mouse X");
        rotationY = mouseX * mouseSensitivity;

        transform.rotation = Quaternion.Euler(0f, rotationY, 0f);
    }
}




