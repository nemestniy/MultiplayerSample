using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class OnlinePlayerController : NetworkBehaviour
{
    public float Speed = 10.0f;

    public NetworkVariable<float> positionX = new();

    private Vector3 originPosition;

    private void Awake()
    {
        originPosition = transform.position;
    }

    private void Start()
    {
        if (!IsOwner)
        {
            var camera = GetComponentInChildren<Camera>();
            if (camera)
            {
                camera.enabled = false;
            }
        }

        transform.position = originPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsOwner)
        {
            Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")).normalized;
            transform.position += direction * Speed * Time.deltaTime;
        }
    }
} 
