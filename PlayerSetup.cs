using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class PlayerSetup : NetworkBehaviour {

    [SerializeField] Behaviour[] NeedToBeDisable;

	// Use this for initialization
	void Start () {
        if (!isLocalPlayer) {
            for (int i = 0; i < NeedToBeDisable.Length; i++)
            {
                NeedToBeDisable[i].enabled = false;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
