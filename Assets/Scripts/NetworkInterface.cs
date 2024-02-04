using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class NetworkInterface : MonoBehaviour
{
    public void OnHostButtonClick()
    {
        NetworkManager.Singleton.StartHost();
    }
    
    public void OnClientButtonClick()
    {
        NetworkManager.Singleton.StartClient();
    }
}
