using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 offset;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform.offset);
    }
}
