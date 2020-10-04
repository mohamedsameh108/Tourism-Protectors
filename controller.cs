using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
    public CharacterController playerControl;
    public float playerSpeed = 0.2f;
    public Joystick joystick;

    //Current state of some of the stats defined above.
    private float actPlayerSpeed;

    private Vector3 playerMotionVector;

    private void GetInput () {
        playerMotionVector = new Vector3 (joystick.Horizontal, 0.0f, joystick.Vertical);
    }

    private void Movement () {
        playerControl.Move (playerMotionVector * actPlayerSpeed);
    }

    private void Start () {
        actPlayerSpeed = playerSpeed;
    }

    private void Update () {
        GetInput ();
        Movement ();
    }
}