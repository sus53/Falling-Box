using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2Movement : MonoBehaviour
{
    private float moveSpeed = 5;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.D)){
            Vector2 move = transform.position;
            move.x += moveSpeed * Time.deltaTime;
            transform.position = move;
            rb.velocity = new Vector2 (0,0);
        }
        if(Input.GetKey(KeyCode.A)){
            Vector2 move = transform.position;
            move.x -= moveSpeed * Time.deltaTime;
            transform.position = move;
            rb.velocity = new Vector2 (0,0);
        }
        if(Input.GetKey(KeyCode.W)){
            Vector2 move = transform.position;
            move.y += moveSpeed * Time.deltaTime;
            transform.position = move;
            rb.velocity = new Vector2 (0,0);
        }
        if(Input.GetKey(KeyCode.S)){
            Vector2 move = transform.position;
            move.y -= moveSpeed * Time.deltaTime;
            transform.position = move;
            rb.velocity = new Vector2 (0,0);
        }
    }
    
    void OnTriggerEnter2D(Collider2D target){
    if (target.tag =="Enemy"){
        Time.timeScale = 0f;
    }
    }
    
}
