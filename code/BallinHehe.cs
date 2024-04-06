using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallinHehe : MonoBehaviour
{
    private Rigidbody2D rb2D;
    [SerializeField] private float jumpMove;
    [SerializeField] private float xMove;

    private float moveX;
    
    private ManageScenes sceneManager;
    [SerializeField] private int scenario;
    private float fullDir;
    

    void Awake()
    {
    }

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.gravityScale *= 0.25f;
    }

    void Update()
    {
        fullDir = moveX / Mathf.Abs(moveX);
    }
    
    public void UpMove(float dir)
    {
        moveX = xMove * dir;
        rb2D.velocity = new Vector2(moveX, jumpMove);
        Invoke(nameof(SetinGravity), 1.2f);
    }

    private void SetinGravity()
    {
        rb2D.velocity = new Vector2(moveX, -5f);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wall"))
        {
            float newDir = fullDir * -1;
            UpMove(newDir);
        }
    }
}