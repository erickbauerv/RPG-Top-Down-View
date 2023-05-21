using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D playerRigidbody2D;
    private Vector2 newPosition;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        newPosition = new Vector2(horizontalInput, verticalInput).normalized * speed;
    }

    void FixedUpdate()
    {
        playerRigidbody2D.MovePosition(playerRigidbody2D.position + (newPosition * Time.fixedDeltaTime));
    }
}
