using UnityEngine;

public class Move : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed;
    public float horizontal;


    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

}
