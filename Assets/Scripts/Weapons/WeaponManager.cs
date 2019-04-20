using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    private GameObject Gun;
    private GameObject Chainsaw;

    void Start()
    {
        Gun = MainStore.Player.transform.Find("Gun").gameObject;
        Chainsaw = MainStore.Player.transform.Find("Chainsaw").gameObject;
        Chainsaw.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Gun.SetActive(true);
            Chainsaw.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Chainsaw.SetActive(true);
            Gun.SetActive(false);
        }
    }
}
