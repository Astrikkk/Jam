using UnityEngine;

public class Beans : MonoBehaviour
{
    private Vector2 move;
    public float speedY;
    public Rigidbody2D rb;
    public GameObject Player;

    public GameObject GameManager;

    private void Update()
    {
        move.y += speedY;

        float Bean_Dist = Vector3.Distance(Player.transform.position, gameObject.transform.position);

        if(Bean_Dist > 15)
        {
            Destroy(gameObject);
        }

        if(GameManager.GetComponent<Score>().score == 1000)
        {
            speedY = 0.9f;
        }
    }

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        rb = this.GetComponent<Rigidbody2D>();
        GameManager = GameObject.FindGameObjectWithTag("GameManager");
    }

    void FixedUpdate()
    {
        rb.MovePosition(GetComponent<Rigidbody2D>().position + move * speedY * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            GameManager.GetComponent<GameManager>().BeansCount += 1;
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
