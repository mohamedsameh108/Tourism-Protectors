﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class webcamscript : MonoBehaviour {
    public GameObject webCameraPlane;

    // Use this for initialization
    void Start () {
        //Optimized Camera For Mobile Platform
        if (Application.isMobilePlatform) {
            GameObject cameraParent = new GameObject ("camParent");
            cameraParent.transform.position = this.transform.position;
            this.transform.parent = cameraParent.transform;
            cameraParent.transform.Rotate (Vector3.right, 90);
        }

        Input.gyro.enabled = true;

        WebCamTexture webCameraTexture = new WebCamTexture ();
        webCameraPlane.GetComponent<MeshRenderer> ().material.mainTexture = webCameraTexture;
        webCameraTexture.Play ();
    }

    // Update is called once per frame
    void Update () {
        //Control Camera Using Gyroscope
        Quaternion cameraRotation = new Quaternion (Input.gyro.attitude.x, Input.gyro.attitude.y, -Input.gyro.attitude.z, -Input.gyro.attitude.w);
        this.transform.localRotation = cameraRotation;

    }
}