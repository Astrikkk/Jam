using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private Vector2 movement;
    public static int SkinNum = 0;
    public GameObject[] Skins;

    void Start()
    {
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("IncrementTimeScale", 1f, 1f);
        if (Skins.Length > 0)
        {
            GameObject skinObject = Instantiate(Skins[SkinNum], transform.position, Quaternion.identity);
            skinObject.transform.parent = transform;
        }
    }


    void IncrementTimeScale()
    {
        Time.timeScale += 0.02f;
    }

    void FixedUpdate()
    {
        rb.MovePosition(GetComponent<Rigidbody2D>().position + movement * speed * Time.fixedDeltaTime);
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
    }
    public void ChangeSkin()
    {
        SkinNum++;
        if (SkinNum == 6) SkinNum = 0;
    }
}