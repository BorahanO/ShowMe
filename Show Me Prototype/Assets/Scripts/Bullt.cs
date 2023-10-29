using System;
using UnityEngine;

public class Bullt : MonoBehaviour
{
    [SerializeField] private float speed;

    void Update()
    {
        // Move the projectile upward
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
           Destroy(gameObject);
        }
    }
}