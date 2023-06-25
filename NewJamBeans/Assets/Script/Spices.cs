using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spices : MonoBehaviour
{
    private GameObject DeathPanel;
    private Vector2 move;
    private GameObject Player;
    private GameObject Spawn;
    private GameObject Map;

    public GameObject GameManager;

    void Start()
    {
        DeathPanel = GameObject.FindGameObjectWithTag("Panel");
        Player = GameObject.FindGameObjectWithTag("Player");
        Spawn = GameObject.FindGameObjectWithTag("Spawn");
        GameManager = GameObject.FindGameObjectWithTag("GameManager");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
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
}
