using UnityEngine;

public class Beans : MonoBehaviour
{
    private Vector2 move;
    public float speedY;
    public Rigidbody2D rb;
    public GameObject Player;

    private void Update()
    {
        move.y += speedY;

        float Bean_Dist = Vector3.Distance(Player.transform.position, gameObject.transform.position);

        if(Bean_Dist > 15)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        rb = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.MovePosition(GetComponent<Rigidbody2D>().position + move * speedY * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {

            Destroy(gameObject);
        }
    }
}
