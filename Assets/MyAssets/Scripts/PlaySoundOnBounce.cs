using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnBounce : MonoBehaviour
{
    private AudioSource audioSource;
    private Rigidbody rigidBody;

    private void Awake() {
        audioSource = GetComponent<AudioSource>();
        rigidBody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other) {
        Vector3 velocity = rigidBody.velocity;
        audioSource.volume = velocity.magnitude / 10;
        audioSource.Play();
    }
}
