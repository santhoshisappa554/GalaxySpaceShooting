using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    EnemyMovement enemy;
    AudioSource enemydestroySound;
    public AudioClip enemyClip;
    void Start()
    {
        enemydestroySound = GameObject.Find("Shooter").GetComponent<AudioSource>();
    }

    void Update()
    {
        if (enemy == null)
        {
            enemydestroySound.clip = enemyClip;
            enemydestroySound.Play();
        }
    }

}
