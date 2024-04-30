using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMov : MonoBehaviour
{
    public float moveSpeed = 3f; 

    private int direction = 1; 

    void Update()
    {
        transform.Translate(Vector3.right * direction * moveSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            SwitchDirection();
        }
    }

    void SwitchDirection()
    {
        direction *= -1; 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FootPlayer"))
        {
            Destroy(gameObject);
        }
    }
}
