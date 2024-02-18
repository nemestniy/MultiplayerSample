using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class OnlinePlayerController2D : NetworkBehaviour
{
    public float Speed = 10.0f;

    public NetworkVariable<float> positionX = new();

    // Update is called once per frame
    void Update()
    {
        if (IsOwner)
        {
            transform.position += Vector3.right * Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        }
    }
} 
