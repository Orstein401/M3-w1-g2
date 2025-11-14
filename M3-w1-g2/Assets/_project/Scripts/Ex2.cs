using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex2 : MonoBehaviour
{
    [SerializeField] float MaxDistance;
    private Vector2 startposition;

    private Rigidbody2D rb;
    [SerializeField] private float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startposition = rb.position;
    }

    void FixedUpdate()
    {
        Vector2 Velocity = rb.velocity;
        Velocity.x = Input.GetAxis("Horizontal") * speed;
        Velocity.y = Input.GetAxis("Vertical") * speed;
        rb.velocity = Velocity;

        //Vector2 b = MaxDistance -(Vector2)transform.position;
        //Debug.Log(b);
        //float a=Vector2.Distance(b,MaxDistance);
        //Debug.Log(a);

        //float a = Vector2.Distance(startposition, MaxDistance);
        ////Debug.Log(a);

        //float b = Vector2.Distance(transform.position, MaxDistance);
        //Debug.Log(b+"d");
        //if (b <= a)
        //{
        //    transform.position = startposition;
        //}

        //if (transform.position.x > MaxDistance.x || transform.position.y > MaxDistance.y)
        //{
        //    transform.position = startposition;
        //}

        //if (transform.position.x > MaxDistance || transform.position.y > MaxDistance || transform.position.x < -MaxDistance || transform.position.y < -MaxDistance)
        //{
        //    transform.position = startposition;
        //}

        float a = Vector2.Distance(startposition, transform.position);
        if (a >= MaxDistance)
        {
            transform.position = startposition;
        }

    }

}
