using UnityEngine;

public class Cloud : MonoBehaviour
{
    private Vector2 move;
    public float speedY;
    public Rigidbody2D rb;
    public GameObject Player;

    public float Radius = 10f;
    public LayerMask Leaf;
    public LayerMask Bean;

    public GameObject GameManager;

    private void Update()
    {
        move.y += speedY;

        float Cloud_Dist = Vector3.Distance(Player.transform.position, gameObject.transform.position);

        if(Cloud_Dist > 15)
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
            Collider2D[] LeafAktive = Physics2D.OverlapCircleAll(transform.position, Radius, Leaf);
            foreach(Collider2D leaf in LeafAktive)
            {
                leaf.GetComponent<PlatformLeafs>().speedY -= 0.05f;
            }

            Collider2D[] BeanAktive = Physics2D.OverlapCircleAll(transform.position, Radius, Bean);
            foreach(Collider2D bean in BeanAktive)
            {
                bean.GetComponent<Beans>().speedY -= 0.04f;
            }
            Destroy(gameObject);
        }
    }
}