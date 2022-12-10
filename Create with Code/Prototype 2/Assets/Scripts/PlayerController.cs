using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float horizontalInput;
    public float speed = 20.0f;
    public float xRange = 20;

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
        //Launch a projectile from the player
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
      }
      //Keep player in bounds
      if (transform.position.x < -xRange)
      {
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
      }
      if (transform.position.x > xRange)
      {
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
      }
       horizontalInput = Input.GetAxis("Horizontal");
       transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
