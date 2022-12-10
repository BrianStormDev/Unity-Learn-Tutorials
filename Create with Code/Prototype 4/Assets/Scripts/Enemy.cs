using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;
    private Rigidbody enemyRb;
    private GameObject player;
    private float lowerBound = -10f;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        Vector3 lookDirection = (player.transform.position-transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
        if (transform.position.y < lowerBound){
            Destroy(gameObject);
        }
    }
}
