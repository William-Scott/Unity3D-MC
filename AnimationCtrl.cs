using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCtrl : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKey("space"))
          //  anim.Play("HumanoidIdleJumpUp");
        if (Input.GetKey("w"))
            anim.Play("WalkFWD");

       // if (Input.GetKey("w") && Input.GetKey("LeftShift"))
       //     anim.Play("HumanoidRun");

	}
}
