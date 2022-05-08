using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDirection : MonoBehaviour
{
    private Animator anim;
    public Transform player;
    public float speed;
    // Use this for initialization
    void Start()
    {
        anim = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
}
