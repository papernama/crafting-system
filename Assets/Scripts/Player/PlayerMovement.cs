using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    public float speed;
    private float inputX, inputY;
    private Rigidbody2D rb;
    private Animator anime;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Transitioning to running animation
        bool flagRunning = (inputX != 0) || (inputY != 0);
        anime.SetBool("isRunning", flagRunning);

        // Changing face direction of character
        GetComponent<SpriteRenderer>().flipX = (inputX < 0);
    }

    void FixedUpdate() {
        inputX = Input.GetAxisRaw("Horizontal");
        inputY = Input.GetAxisRaw("Vertical");

        print(inputX);
        print(inputY);
        print(rb.velocity);
        print(inputX * speed);
        print(inputY * speed);
        rb.velocity = new Vector2(inputX * speed, inputY * speed);
        print(rb.velocity);

    }
}
