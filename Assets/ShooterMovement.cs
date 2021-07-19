using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float ShooterSpeed;
    public Shooter localshooter;
   
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(horizontal, vertical)*ShooterSpeed;
        rb.position = new Vector2(Mathf.Clamp(rb.position.x, localshooter.xMin, localshooter.xMax), Mathf.Clamp(rb.position.y, localshooter.yMin, localshooter.yMax));

      
    }
    [System.Serializable]
    public class Shooter
    {
        public float xMin, xMax, yMin, yMax;
    }
   
}
