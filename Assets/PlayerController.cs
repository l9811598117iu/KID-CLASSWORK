using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    Animator Anim;
	// Use this for initialization
	void Start () {
        Anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.R))
        {
            Anim.SetInteger("Anim", 1);
        }
        else
        {
            Anim.SetInteger("Anim", 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Anim.SetInteger("Anim", 2);
        }
    }
}
