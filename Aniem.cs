﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aniem : MonoBehaviour {
    public Animation anim;
    // Start is called before the first frame update
    void Start () {
        anim = GetComponent<Animation> ();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown (KeyCode.W)) {
            anim.Play ("Walking");
        }
        if (Input.GetKeyDown (KeyCode.S)) {
            anim.Play ("Walking");
        }
        if (Input.GetKeyDown (KeyCode.A)) {
            anim.Play ("Walking");
        }
        if (Input.GetKeyDown (KeyCode.D)) {
            anim.Play ("Walking");
        }
        }
    }