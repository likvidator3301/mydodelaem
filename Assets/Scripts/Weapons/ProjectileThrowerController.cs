using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileThrowerController : MonoBehaviour
{
    public float CooldownInSecond = 0;
    private bool ready = true;
    void Update()
    {
        if (ready && Input.GetMouseButtonDown(0))
        {
			GetComponent<AudioSource>().Play();
            var mousePosition = MainStore.Camera.ScreenPointToRay(Input.mousePosition).GetPoint(1);
            var direction = (mousePosition - GetComponent<ProjectileThrower>().SpawnPoint.transform.position).normalized;
            GetComponent<ProjectileThrower>().Shoot(direction);
            if (CooldownInSecond > 0)
                StartCoroutine(Cooldown());
        }
    }

    private IEnumerator Cooldown()
    {
        ready = false;
        yield return new WaitForSeconds(CooldownInSecond);
        ready = true;
    }
}
