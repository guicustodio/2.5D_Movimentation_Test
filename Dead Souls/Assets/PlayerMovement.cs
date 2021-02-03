using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;               

    public GameObject Player;

    private Rigidbody rb;

    public float vInput;
    public float hInput;

    [Range(1, 10)]
    public float jumpVelocity;

    void Start()
    {
        rb = Player.GetComponent<Rigidbody>();
    }

    void Update()
    {
        Movement();

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }
    void Movement()
    {
        hInput = Input.GetAxis("Horizontal");
        Player.transform.Translate(new Vector3(hInput, 0, 0) * speed * Time.deltaTime);

        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x, -8, 6),
            transform.position.y
            );
    }
    void Jump() 
    {
        rb.velocity = Vector3.up * jumpVelocity;
    }
}
