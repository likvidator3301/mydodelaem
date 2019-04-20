using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AIMoveController : MonoBehaviour
{
    public float Speed;
    public int Seed;

    private bool hasPath;
    private Vector3 target;
    private Rigidbody2D rigidbody;
    private GameObject[] checkPoints;
    private System.Random random;

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
            var direction = target - transform.position;
            if (direction.magnitude <= 1)
                hasPath = false;
            rigidbody.AddForce(direction.normalized * Speed * Time.deltaTime);
        }
        else
        {
            target = checkPoints[random.Next(0, checkPoints.Length)].transform.position;
            hasPath = true;
        }
    }
}
