using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTimeout : MonoBehaviour
{
    public float TTL = 2f;

    void Start()
    {
        StartCoroutine(DieByTimeout());
    }


    private IEnumerator DieByTimeout()
    {
        yield return new WaitForSeconds(TTL);
        Destroy(gameObject);
    }
}
