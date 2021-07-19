using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{

    AudioSource enemydestroySound;
    public AudioClip enemyClip;
    void Start()
    {
        enemydestroySound = GameObject.Find("Shooter").GetComponent<AudioSource>();
    }

 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject, 0.0f);
        enemydestroySound.clip = enemyClip;
        enemydestroySound.Play();

    }
}
