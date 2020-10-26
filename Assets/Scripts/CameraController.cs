using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform target;
    private float smoothSpeed = 3f;
    private float minX = -39.55f;
    private float maxX = 16.55f;
    private float minY = -12.85f;
    private float maxY = 6.35f;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void LateUpdate()
    {
        // tradition method of camera movement
        //transform.position = new Vector3(target.position.x, target.position.y, -10);

        // smooth camera movement
        transform.position = Vector3.Lerp(transform.position, new Vector3(target.position.x, target.position.y, -10), smoothSpeed * Time.deltaTime);

        // limit the camera range
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX),
                                         Mathf.Clamp(transform.position.y, minY, maxY),
                                         -10);
    }
}
