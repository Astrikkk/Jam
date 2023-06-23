using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.MovePosition(GetComponent<Rigidbody2D>().position + movement * speed * Time.fixedDeltaTime);
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
    }
}