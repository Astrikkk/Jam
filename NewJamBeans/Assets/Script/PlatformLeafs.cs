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

    void Start()
    {
        DeathPanel = GameObject.FindGameObjectWithTag("Panel");
        rb = this.GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag("Player");
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
    }

    private void Update()
    {
        move.y += speedY;
        float Leaf_Dist = Vector3.Distance(Player.transform.position, gameObject.transform.position);

        if(Leaf_Dist > 15)
        {
            Destroy(gameObject);
        }

    }

    void FixedUpdate()
    {
        rb.MovePosition(GetComponent<Rigidbody2D>().position + move * speedY * Time.fixedDeltaTime);
    }
}
