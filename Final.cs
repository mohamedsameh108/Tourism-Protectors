using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Final : MonoBehaviour {
    // Adjust the speed for the application.
    public float speed = 1.0f;
    public Animation anim;
    // The target (cylinder) position.
    private Transform target;
    public AudioClip SoundToPlay;
    public AudioClip SoundToPlay1;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;
    public bool alreadyPlayed1 = false;
    public GameObject uiObject;
    public GameObject uiObject1;
    void Start () {
        audio = GetComponent<AudioSource> ();
        uiObject.SetActive (true);
        uiObject1.SetActive (false);
        anim = GetComponent<Animation> ();
        // Position the cube at the origin.
        transform.position = new Vector3 (-650.5f, -8.3f, 864.1f);

        // Create and position the cylinder. Reduce the size.
        GameObject cylinder = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
        // Grab cylinder values and place on the target.
        target = cylinder.transform;
        target.transform.localScale = new Vector3 (0.0f, -175.435f, 0.0f);
        target.transform.position = new Vector3 (-657.0f, -8.3f, 1028.2f);
        anim.Play ("Walk");

    }
    void First () {
        float step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards (transform.position, target.position, step);
        if (!alreadyPlayed) {
            audio.PlayOneShot (SoundToPlay, Volume);
            alreadyPlayed = true;
        }
        Invoke ("Second", SoundToPlay.length);
    }

    void Second () {
        transform.eulerAngles = new Vector3 (0.0f, -806.515f, 0.0f);
        // Move our position a step closer to the target.
        target.transform.position = new Vector3 (-726.3f, -8.3f, 1032.5f);
        float step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards (transform.position, target.position, step);
        // Check if the position of the cube and sphere are approximately equal.
            if (!alreadyPlayed1) {
                uiObject.SetActive (false);
                audio.PlayOneShot (SoundToPlay1, Volume);
                alreadyPlayed1 = true;
                uiObject1.SetActive (true);
            Invoke ("New", SoundToPlay1.length);
        }
    }
    void New () {
        SceneManager.LoadScene (0);
    }
    void Update () {
        First ();

    }
}