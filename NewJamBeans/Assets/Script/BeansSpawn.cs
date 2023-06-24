using UnityEngine;

public class BeansSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject obj;
    float RandX;
    Vector2 whereToSpawn;
    [SerializeField]
    private float spawnRate = 2f;
    float nextSpawn = 0.0f;
    public GameObject GameManager;

    void Start()
    {
        GameManager = GameObject.FindGameObjectWithTag("GameManager");
    }

    void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            RandX = Random.Range(-3.77f, 3.77f);
            whereToSpawn = new Vector2(RandX, transform.position.y);
            Instantiate(obj, whereToSpawn, Quaternion.identity);
        }

        if(GameManager.GetComponent<Score>().score == 1000)
        {
            spawnRate = 1.6f;
        }
    }
}
