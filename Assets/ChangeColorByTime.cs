using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorByTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Do());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Do()
    {
        var a = 0f;
        while (a < 8f)
        {
            a += 0.5f;
            Debug.Log("Делаю минут, а равно " + a.ToString());
            yield return new WaitForSeconds(0.5f);
            var color = gameObject.GetComponent<Image>().color;
            gameObject.GetComponent<Image>().color = new Color(color.r, color.g, color.b, color.a - 10/255f);
        }
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
