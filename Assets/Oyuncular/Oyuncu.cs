using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;//extra
using UnityEngine.Networking;//extra

public class Oyuncu : NetworkBehaviour {

    private Vector3 girdiDegerleri;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(!isLocalPlayer)
        {
            return;
        }

        girdiDegerleri.x = CrossPlatformInputManager.GetAxis("Horizontal");
        girdiDegerleri.y = 0f;
        girdiDegerleri.z = CrossPlatformInputManager.GetAxis("Vertical");

        transform.Translate(girdiDegerleri);
    }

    public override void OnStartLocalPlayer()
    {
        GetComponentInChildren<Camera>().enabled = true;
    }
}
