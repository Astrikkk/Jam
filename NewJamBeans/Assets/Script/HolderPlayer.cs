using UnityEngine;

public class HolderPlayer : MonoBehaviour
{
    public Transform ObjectPos;
    private Vector2 move;
    public float speedY;
    public Rigidbody2D rb;

    void Start()
    {
        
    }

    void Update()
    {
        float Dist = Vector2.Distance(transform.position, ObjectPos.position);

        move.y -= speedY;

        print(Dist);

        if(Dist <= 0.9)
        {
            transform.position = new Vector3(1.195143f, -16.11f, 0f);
            this.enabled = false;
        }

        
    }

    void FixedUpdate()
    {
        rb.MovePosition(GetComponent<Rigidbody2D>().position + move * speedY * Time.fixedDeltaTime);
    }
}
