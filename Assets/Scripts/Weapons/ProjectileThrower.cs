using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileThrower : MonoBehaviour
{
    public GameObject SpawnPoint;
    public GameObject Projectile;
    public float Speed = 10f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Shoot();
    }

    void Shoot()
    {
        var projectile = Instantiate(Projectile, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
        var rigid = projectile.GetComponent<Rigidbody2D>();
        var mousePosition = MainStore.Camera.ScreenPointToRay(Input.mousePosition).GetPoint(1);
        var direction =  (mousePosition - SpawnPoint.transform.position).normalized;
        rigid.AddForce(direction * Speed * Time.deltaTime);
    }
}
