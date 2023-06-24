using UnityEngine;

public class RandomSpawnLeaf : MonoBehaviour
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
            RandX = Random.Range(1, 3);
            if(RandX == 1)
            {
                whereToSpawn = new Vector2(-3.53f, transform.position.y);
                Instantiate(obj, whereToSpawn, Quaternion.identity);
            }
            else if(RandX == 2)
            {
                whereToSpawn = new Vector2(2.76f, transform.position.y);
                Instantiate(obj, whereToSpawn, Quaternion.Euler(0, 180, 0));
            }
        }

        if(GameManager.GetComponent<Score>().score == 1000)
        {
            spawnRate = 1f;
        }
    }
}