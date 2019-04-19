using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateOnDestroy : MonoBehaviour
{
    public GameObject ToCreate;

    void OnDestroy()
    {
        Instantiate(ToCreate, transform.position, transform.rotation);
    }
}
