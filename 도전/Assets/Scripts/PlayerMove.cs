using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    Rigidbody rigidBody = null;
    public GameObject particle;
    private AudioSource audioSource1;
    public AudioClip audioClip1;

    // Update is called once per frame;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        audioSource1 = gameObject.AddComponent<AudioSource>();
        audioSource1.clip = audioClip1;
        audioSource1.loop = false;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("point"))
        {
            Destroy(other.gameObject);
            audioSource1.Play();
            ScoreManager.instance.score += 10;
        }
        if (other.gameObject.layer == LayerMask.NameToLayer("time 5s"))
        {
            Destroy(other.gameObject);
            audioSource1.Play();
            TimeManager.plusTime += 5;
        }

        if (other.gameObject.layer == LayerMask.NameToLayer("time 10s"))
        {
            Destroy(other.gameObject);
            audioSource1.Play();
            TimeManager.plusTime += 10;
        }
        if (other.gameObject.layer == LayerMask.NameToLayer("bomb"))
        {
            Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
