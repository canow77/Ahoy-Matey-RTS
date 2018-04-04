using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking; //ekstra

public class MyNetworkManager : NetworkManager
{
    public void MyStartHost() // butonda çağıralacak metod
    {
        Debug.Log(Time.timeSinceLevelLoad + " Starting Host." );
        StartHost();
    }

    public override void OnStartHost() 
    {
        Debug.Log(Time.timeSinceLevelLoad + " Host started." );
    }

    public override void OnStartClient(NetworkClient client)
    {
        Debug.Log(Time.timeSinceLevelLoad + " client start requested");
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log(Time.timeSinceLevelLoad + " Clientsu IP ye bağlandı: " + conn.address);
    }

    void PrintDots()
    {

    }
}
