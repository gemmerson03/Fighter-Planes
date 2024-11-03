using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject player;
    public GameObject enemy;
    public GameObject enemy2; 

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, transform.position, Quaternion.identity);
        InvokeRepeating("CreateEnemy", 1f, 3f); // Ensure CreateEnemy has the correct signature
        InvokeRepeating("CreateEnemy2", 2f, 4f); // Ensure CreateEnemy has the correct signature
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Make sure this method is defined correctly
    void CreateEnemy()
    {
        Instantiate(enemy, new Vector3(Random.Range(-9f, 9f), 8f, 0), Quaternion.identity);
    }

    // Make sure this method is defined correctly 
    void CreateEnemy2()
    {
        Instantiate (enemy2, new Vector3(Random.Range(-9f, 9f),8f, 0), Quaternion.identity);
    }
}
