﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPearsonController : MonoBehaviour
{

    [SerializeField] float mouseSensitivity = 50f;
    float xRotation = 0.0f;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -70f, 70f);
        transform.localRotation= Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);

    }
}
