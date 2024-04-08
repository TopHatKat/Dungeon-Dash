using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float rotationSpeed;

    private float mouseX;

    void Start()
    {
        player = FindObjectOfType<PlayerController>().gameObject;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform.position);

        mouseX += Input.GetAxis("Mouse X");

        transform.RotateAround(player.transform.position, Vector3.up, mouseX * rotationSpeed);
    }
}
