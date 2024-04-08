using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private GameObject cam;
    

    [SerializeField] private float speed;
    [SerializeField] private float jump;

    private float gravity = -20f;
    private float velocity;

    float x;
    float z;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        cam = FindObjectOfType<MoveCamera>().gameObject;
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        Vector3 input = new Vector3(x, 0, z) * speed;

        // calculates vertical velocity due to gravity
        velocity = (controller.isGrounded && velocity <= 1) ? -0.5f : velocity + gravity * Time.deltaTime;

        if(x != 0 || z != 0)    // only turn player when there's an input
        {
            float rotationY = Mathf.Atan2(x, z) * Mathf.Rad2Deg;            // what angle is input towards.
            float targetAngle = rotationY + cam.transform.eulerAngles.y;    // account for direction camera is facing
            transform.rotation = Quaternion.Euler(0, targetAngle, 0);       // rotate player to face direction of movement.
        }

        // combine vector3 to determine which direction to move character
        Vector3 move = Quaternion.Euler(0, cam.transform.eulerAngles.y, 0) * input + new Vector3(0, velocity, 0);

        controller.Move(Time.deltaTime * move); // move character
    }
}