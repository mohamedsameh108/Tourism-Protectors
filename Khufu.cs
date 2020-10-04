using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Khufu : MonoBehaviour {
    // Adjust the speed for the application.
    public float speed = 1.0f;
    public Animation anim;
    // The target (cylinder) position.
    private Transform target;
    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;
    public GameObject uiObject;
    void Start () {
        audio = GetComponent<AudioSource> ();
        uiObject.SetActive (true);
        anim = GetComponent<Animation> ();
        // Position the cube at the origin.
        transform.position = new Vector3 (-854.6f, -8.3f, 848.7f);

        // Create and position the cylinder. Reduce the size.
        GameObject cylinder = GameObject.CreatePrimitive (PrimitiveType.Cylinder);

        // Grab cylinder values and place on the target.
        target = cylinder.transform;
        target.transform.localScale = new Vector3 (0.0f, -175.435f, 0.0f);
        target.transform.position = new Vector3 (-650.5f, -8.3f, 864.1f);
        anim.Play ("Walk");
    }

    void Second () {
        // Move our position a step closer to the target.
        // Check if the position of the cube and sphere are approximately equal.
        float step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards (transform.position, target.position, step);
        if (!alreadyPlayed) {
                audio.PlayOneShot (SoundToPlay, Volume);
                alreadyPlayed = true;
            }
        Invoke ("New", SoundToPlay.length);
    }
    void New () {
        SceneManager.LoadScene (4);
    }
    void Update () {
        Second ();
    }
}