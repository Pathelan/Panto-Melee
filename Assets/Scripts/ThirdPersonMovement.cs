using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement  : MonoBehaviour
{
    // References
    [SerializeField] private CharacterController controller;

    // Gravity stuff
    private float _gravity = 1f;
    [SerializeField] private float gravityMultiplier = 3f;
    private float _velocity;

    [SerializeField] private float speed = 6f;
    [SerializeField] private float turnSmoothTime = 0.1f; // How long it takes to rotate
    private float turnSmoothVelocity; 

    // Can the player move?
    [HideInInspector] public bool isStunned;

    // Update is called once per frame
    void Update()
    {
        ApplyGravity();
        ApplyMovement();


    }


    private void ApplyGravity()
    {
        if (controller.isGrounded)
        {
            _velocity = 0;
        } else
        {
            _velocity -= _gravity * Time.deltaTime;
        }
    }

    private void ApplyMovement()
    {
        if (!isStunned) // Only move when not stunned
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");

            Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

            if (direction.magnitude >= 0.1f)
            {
                float targetAngle = (Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg) - 90f;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);

                controller.Move(direction * speed * Time.deltaTime);
            }

        }

        // Gravity
        controller.Move(new Vector3(0f, _velocity, 0f));
    }
}
