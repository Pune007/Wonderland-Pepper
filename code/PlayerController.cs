using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private string inputField;
    [SerializeField] private float speed;
    private Rigidbody2D rb2D;
    
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputMove = Input.GetAxisRaw(inputField);
        rb2D.velocity = new Vector2(inputMove * speed, rb2D.velocity.y);

        if (inputMove > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (inputMove < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (inputMove != 0)
        {
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }
    }
}
