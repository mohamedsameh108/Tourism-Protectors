using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour {
    public GameObject player;
    public GameObject about;
    public GameObject website;
    public GameObject exit;
    public GameObject tour;
    public GameObject guide;
    public GameObject photo;
    public GameObject back1;
    public void backmain () {
        player.SetActive (true);
        about.SetActive (true);
        website.SetActive (true);
        exit.SetActive (true);
        tour.SetActive (false);
        guide.SetActive (false);
        photo.SetActive (false);
        back1.SetActive (false);
    }
}