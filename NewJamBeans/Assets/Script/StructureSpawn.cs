using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructureSpawn : MonoBehaviour
{

    [SerializeField]
    private List<GameObject> obj;
    float RandX;
    Vector2 whereToSpawn;
    [SerializeField]
    private float spawnRate = 10f;
    float nextSpawn = 0.0f;
    public GameObject GameManager;

    void Start()
    {
        GameManager = GameObject.FindGameObjectWithTag("GameManager");
        nextSpawn = Time.time + 15f;
        whereToSpawn = new Vector2(0f, -15f);
    }

    private void Update()
    {
        if (Time.time > nextSpawn)
        {
            int ran = Random.Range(0, obj.Count);
            nextSpawn = Time.time + spawnRate;
            Instantiate(obj[ran], whereToSpawn, Quaternion.identity);
        }

        if (GameManager.GetComponent<Score>().score == 1000)
        {
            spawnRate = 8f;
        }
    }

}
