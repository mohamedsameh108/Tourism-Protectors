using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour {
    public GameObject play;
    public GameObject about;
    public GameObject website;
    public GameObject exit;
    public GameObject tour;
    public GameObject guide;
    public GameObject photo;
    public GameObject back1;
    public void startmain () {
        play.SetActive (false);
        about.SetActive (false);
        website.SetActive (false);
        exit.SetActive (false);
        tour.SetActive (true);
        guide.SetActive (true);
        photo.SetActive (true);
        back1.SetActive (true);
    }
}