using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    public Joystick joystick;
    public float RotationSensitivity = 35.0f;
    public float minAngle = -90.0f;
    public float maxAngle = 90.0f;
    //Rotation Value
    float yRotate = 0.0f;
    float xRotate = 0.0f;
    // Update is called once per frame
    void Update () {

        //Rotate Y view
        yRotate += joystick.Horizontal * RotationSensitivity * Time.deltaTime;
        xRotate += joystick.Vertical * RotationSensitivity * Time.deltaTime;
        xRotate = Mathf.Clamp (xRotate, minAngle, maxAngle);
        transform.eulerAngles = new Vector3 (xRotate, yRotate, 0.0f);

    }
}