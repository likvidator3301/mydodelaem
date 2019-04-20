using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class AIMoveController : MonoBehaviour
{
    public float Speed;
    public int Seed;
    public float RangeOfView;
    public float MoveRange;

    private bool hasPath;
    private Vector3 target;
    private Rigidbody2D rigidbody;
    private GameObject[] checkPoints;
    private System.Random random;
    private bool shooting;
    private bool ready = true;

    void Start()
    {
        checkPoints = GameObject.FindGameObjectsWithTag("AICheckPoint").Where(l => (transform.position - l.transform.position).magnitude <= MoveRange).ToArray();
        rigidbody = GetComponent<Rigidbody2D>();
        random = new System.Random(Seed);
    }

    void Update()
    {
        CheckPlayer();
        if (hasPath)
        {
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

    void CheckPlayer()
    {
        var direction = MainStore.Player.transform.position - transform.position;
        var dist = direction.magnitude;
        if (ready && dist <= RangeOfView)
        {
            var gun = GetComponent<ProjectileThrower>();
            var projectileDirection = (MainStore.Player.transform.position - gun.SpawnPoint.transform.position).normalized;
            var angle = Vector3.Angle(MainStore.Player.transform.position - transform.position, Vector3.up);
            if (MainStore.Player.transform.position.x > transform.position.x)
                angle = -angle;
            gameObject.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            gun.Shoot(projectileDirection);
            StartCoroutine(Cooldown());
        }
    }

    private IEnumerator Cooldown()
    {
        ready = false;
        yield return new WaitForSeconds(1);
        ready = true;
    }
}
