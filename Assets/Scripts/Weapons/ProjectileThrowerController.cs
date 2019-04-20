using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileThrowerController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var mousePosition = MainStore.Camera.ScreenPointToRay(Input.mousePosition).GetPoint(1);
            var direction = (mousePosition - GetComponent<ProjectileThrower>().SpawnPoint.transform.position).normalized;
            GetComponent<ProjectileThrower>().Shoot(direction);
        }
    }
}
