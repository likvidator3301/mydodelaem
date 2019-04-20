using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileThrower : MonoBehaviour
{
    public GameObject SpawnPoint;
    public GameObject Projectile;
    public float Speed = 10f;

    public void Shoot(Vector3 direction)
    {
        var projectile = Instantiate(Projectile, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
        var rigid = projectile.GetComponent<Rigidbody2D>();
        rigid.AddForce(direction.normalized * Speed * Time.deltaTime);
    }
}
