using UnityEngine;

public class Beans : MonoBehaviour
{
    private Vector2 move;
    public float speedY;
    public GameObject Player;

    public GameObject GameManager;

    private void Update()
    {

        float Bean_Dist = Vector3.Distance(Player.transform.position, gameObject.transform.position);

        if(Bean_Dist > 50)
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
            GameManager.GetComponent<GameManager>().BeansCount += 1;
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
