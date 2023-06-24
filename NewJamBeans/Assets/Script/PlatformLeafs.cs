using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformLeafs : MonoBehaviour
{
    public GameObject DeathPanel;
    private Vector2 move;
    public float speedY;
    public Rigidbody2D rb;
    public GameObject Player;
    public GameObject Spawn;
    public GameObject Map;

    public GameObject GameManager;

    void Start()
    {
        DeathPanel = GameObject.FindGameObjectWithTag("Panel");
        rb = this.GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag("Player");
        Spawn = GameObject.FindGameObjectWithTag("Spawn");
        GameManager = GameObject.FindGameObjectWithTag("GameManager");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            Death();
        }
    }

    public void Death()
    {
        DeathPanel.GetComponent<Holder>().defeate = true;
        Player.SetActive(false);
        Spawn.SetActive(false);
        Destroy(gameObject);
    }

    private void Update()
    {
        move.y += speedY;
        float Leaf_Dist = Vector3.Distance(Player.transform.position, gameObject.transform.position);

        if(Leaf_Dist > 15)
        {
            Destroy(gameObject);
        }

        if(GameManager.GetComponent<Score>().score == 1000)
        {
            speedY = 0.9f;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(GetComponent<Rigidbody2D>().position + move * speedY * Time.fixedDeltaTime);
    }
}
