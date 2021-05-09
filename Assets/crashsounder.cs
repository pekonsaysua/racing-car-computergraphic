using UnityEngine;
using System.Collections;

public class crashsounder : MonoBehaviour {

    AudioSource audio;

    public AudioClip crashSound;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (crashSound == null) Debug.LogError("crashSound is null on " + gameObject.name);
        //audio.PlayOneShot(crashSound);
    }
}
