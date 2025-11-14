using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1_move : MonoBehaviour
{
    [SerializeField] float Speed;
    private Rigidbody2D rigid;
    void Start()
    {
        rigid= GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector2 direction= new Vector2(h,v);
        //transform.position= transform.position+ direction*(Speed*Time.deltaTime);
        rigid.MovePosition(rigid.position+direction*(Speed*Time.deltaTime));
    }
}
