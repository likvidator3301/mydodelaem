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
    }

    private void ProcessInput()
    {
        AddForceIfKeyDown(KeyCode.W, Vector2.up * Speed);
        AddForceIfKeyDown(KeyCode.S, Vector2.down * Speed);
        AddForceIfKeyDown(KeyCode.A, Vector2.left * Speed);
        AddForceIfKeyDown(KeyCode.D, Vector2.right * Speed);
    }

    private void AddForceIfKeyDown(KeyCode key, Vector2 force)
    {
        if (Input.GetKey(key))
            rigidbody.AddForce(force * Time.deltaTime);
    }

}
