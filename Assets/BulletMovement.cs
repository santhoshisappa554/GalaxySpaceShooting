using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public GameObject Bullet;
    public float BulletSpeed;
    AudioSource bulletaudio;
    // Start is called before the first frame update
    void Start()
    {
        bulletaudio = GetComponent<AudioSource>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            BulletDirection(Vector2.up);
        }
        

    }
    


    private void BulletDirection(Vector2 direction)
    {
        GameObject bulletref = Instantiate(Bullet);
        bulletref.transform.position = transform.position+ new Vector3(0,2,0);
        Rigidbody2D rb = bulletref.GetComponent<Rigidbody2D>();
        rb.velocity =  Vector2.up * BulletSpeed;
        bulletaudio.Play();
    }
    

}
