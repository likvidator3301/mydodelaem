using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AIMoveController : MonoBehaviour
{
    public float Speed;
    public int Seed;
    public float RangeOfView;
    public bool IsBoxPlayer;
    public GameObject SpawnPoint;
    public GameObject Projectile;
    public float SpeedProjectile = 10f;

    private bool hasPath;
    private Vector3 target;
    private Rigidbody2D rigidbody;
    private GameObject[] checkPoints;
    private System.Random random;
    private bool shooting;

    void Start()
    {
        checkPoints = MainStore.CheckPointsForAI;
        rigidbody = GetComponent<Rigidbody2D>();
        random = new System.Random(Seed);
    }

    void Update()
    {
        if (hasPath)
        {
            CheckPlayer();
            var direction = target - transform.position;
            if (direction.magnitude <= 1)
                hasPath = false;
            rigidbody.AddForce(direction.normalized * Speed * Time.deltaTime);
            transform.up = direction.normalized;
            
        }
        else
        {
            target = checkPoints[random.Next(0, checkPoints.Length)].transform.position;
            hasPath = true;
        }
    }

    private void CheckPlayer()
    {
        var direction = MainStore.Player.transform.position - transform.position;
        var dist = direction.magnitude;
        if (dist <= RangeOfView)
        {
            if (IsBoxPlayer)
                target = MainStore.Player.transform.position;
            else
                target = direction.normalized;

            target = new Vector3(target.x, target.y, -1);
            hasPath = true;
            if (!shooting)
            {
                StartCoroutine(Shooting());
                shooting = true;
            }
        }
    }

    void Shoot()
    {
        var projectile = Instantiate(Projectile, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
        var rigid = projectile.GetComponent<Rigidbody2D>();
        var direction = (MainStore.Player.transform.position - SpawnPoint.transform.position).normalized;
        rigid.AddForce(direction * SpeedProjectile * Time.deltaTime);
    }

    private IEnumerator Shooting()
    {
        while (true)
        {
            Shoot();
            yield return new WaitForSeconds(1);
        }
    }
}
