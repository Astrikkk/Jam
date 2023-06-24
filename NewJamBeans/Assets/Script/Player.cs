using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        Time.timeScale = 1f;
        rb = this.GetComponent<Rigidbody2D>();
        InvokeRepeating("IncrementTimeScale", 1f, 1f);
    }

    void IncrementTimeScale()
    {
        Time.timeScale += 0.02f;
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