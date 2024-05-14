using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    public GameObject enemy;
    public float difficulty = 0.5f;
    private float min_x = -11.9f;
    private float max_x = 9.6f;
    
    void Start()
    {
        StartCoroutine(StartSpawning());    
    }

    IEnumerator StartSpawning(){
        yield return new WaitForSeconds(Random.Range(difficulty,difficulty));
        GameObject enemyClone = Instantiate(enemy);
        float x = Random.Range(min_x,max_x);
        enemyClone.transform.position = new Vector2(x,5);
        StartCoroutine(StartSpawning());
    }

}
