using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    public float Speed = 500f;
    private Rigidbody2D rigidbody;
    public bool Locked;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Locked)
            return;
        ProcessInput();

        var mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        var angle = Vector2.Angle(Vector2.right, mousePosition - transform.position);
        transform.eulerAngles = new Vector3(0f, 0f, transform.position.y < mousePosition.y ? angle - 90  : -angle - 90);

    }

    private void ProcessInput()
    {
        AddForceIfKeyDown(KeyCode.W, Vector3.up * Speed);
        AddForceIfKeyDown(KeyCode.S, -Vector3.up * Speed);
        AddForceIfKeyDown(KeyCode.A, -Vector3.right * Speed);
        AddForceIfKeyDown(KeyCode.D, Vector3.right * Speed);
    }

    private void AddForceIfKeyDown(KeyCode key, Vector2 force)
    {
        if (Input.GetKey(key))
            rigidbody.AddForce(force * Time.deltaTime);
    }

}
