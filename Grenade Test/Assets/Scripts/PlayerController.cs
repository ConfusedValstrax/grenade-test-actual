using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 10f;
    public Vector3 playerVelocity;
    private void Update()
    {
        float z = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");

        playerVelocity = new Vector3(x * moveSpeed * Time.deltaTime, 0, z * moveSpeed * Time.deltaTime);
        rb.AddRelativeForce(playerVelocity, ForceMode.VelocityChange);

        if (z == 0 || x == 0)
        {
            rb.AddRelativeForce(-playerVelocity);
        }
    }
}

