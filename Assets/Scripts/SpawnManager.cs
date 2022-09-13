using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private PlayerController playerControllerScript;
    public GameObject[] ballPrefab;
    private float spawnRangeX = 20;
    private float spawnRangeY = 25;
    private float startDelay = 5;
    private float interval = 3f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBall", startDelay, interval);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
   
    
        void SpawnBall() {
        if (playerControllerScript.gameOver == false) {
            {
                Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnRangeY, 77.44f);
                int ballIndex = Random.Range(0, ballPrefab.Length);
                Instantiate(ballPrefab[ballIndex], spawnpos, ballPrefab[ballIndex].transform.rotation);
            }
        }
    }
    
}
