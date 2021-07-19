using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnLocation : MonoBehaviour
{
    public GameObject enemyPrefab;
    float time = 0;
    ShooterMovement shooter;
    // Start is called before the first frame update
    void Start()
    {
        shooter = GameObject.Find("Shooter").GetComponent<ShooterMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
            time += Time.deltaTime;
            if (time > 2.0f && shooter!=null)
            {

                float value = Random.Range(-2.11f, 2.11f);
                GameObject enemyref = Instantiate(enemyPrefab);
                enemyref.transform.position = new Vector3(value, 5.0f, 0);
                time = 0;
            }
        
    }
}