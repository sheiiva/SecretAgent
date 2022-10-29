using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class HostManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        NetworkManager.Singleton.StartHost();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
