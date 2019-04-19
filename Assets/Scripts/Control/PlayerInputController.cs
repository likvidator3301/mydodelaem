using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    public float Speed = 500f;
    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
        var mousePosition = MainStore.Camera.ScreenPointToRay(Input.mousePosition).GetPoint(1);
        var angle = Vector3.Angle(mousePosition - transform.position, Vector3.up);
        if (mousePosition.x > transform.position.x)
            angle = -angle;
        gameObject.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    private void ProcessInput()
    {
        AddForceIfKeyDown(KeyCode.W, transform.up * Speed);
        AddForceIfKeyDown(KeyCode.S, -transform.up * Speed);
        AddForceIfKeyDown(KeyCode.A, -transform.right * Speed);
        AddForceIfKeyDown(KeyCode.D, transform.right * Speed);
    }

    private void AddForceIfKeyDown(KeyCode key, Vector2 force)
    {
        if (Input.GetKey(key))
            rigidbody.AddForce(force * Time.deltaTime);
    }

}
