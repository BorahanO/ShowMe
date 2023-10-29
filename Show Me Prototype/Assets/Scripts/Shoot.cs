using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float fireRate;
    private float nextFireTime = 0.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFireTime)
        {
            nextFireTime = Time.time + fireRate;
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
    }
}