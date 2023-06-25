using UnityEngine;

public class Cloud : MonoBehaviour
{
    private Vector2 move;
    public float speedY;
    public GameObject Player;

    public float Radius = 10f;
    public LayerMask Leaf;
    public LayerMask Bean;

    public GameObject GameManager;

    private void Update()
    {
        float Cloud_Dist = Vector3.Distance(Player.transform.position, gameObject.transform.position);

        if(Cloud_Dist > 50)
        {
            Destroy(gameObject);
        }

    }

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        GameManager = GameObject.FindGameObjectWithTag("GameManager");
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.up * speedY * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Time.timeScale = 1f;
            Destroy(gameObject);
        }
    }
}