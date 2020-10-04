using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camal : MonoBehaviour {
    public Animation anim;
    // Start is called before the first frame update
    void Start () {
        anim = GetComponent<Animation> ();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown (KeyCode.W)) {
            anim.Play ("Walk");
        }
        if (Input.GetKeyDown (KeyCode.S)) {
            anim.Play ("Walk");
        }
        if (Input.GetKeyDown (KeyCode.A)) {
            anim.Play ("Walk");
        }
        if (Input.GetKeyDown (KeyCode.D)) {
            anim.Play ("Walk");
        }
    }
}