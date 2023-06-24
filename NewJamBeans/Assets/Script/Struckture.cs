using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Struckture : MonoBehaviour
{
    private GameObject DeathPanel;
    private Vector2 move;
    public float speedY;
    private GameObject Player;
    private GameObject Spawn;
    private GameObject Map;

    public GameObject GameManager;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Spawn = GameObject.FindGameObjectWithTag("Spawn");
    }

    private void Update()
    {
        float Leaf_Dist = Vector3.Distance(Player.transform.position, gameObject.transform.position);

        if (Leaf_Dist > 50)
        {
            Destroy(gameObject);
        }

    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.up * speedY * Time.deltaTime);
    }
}
