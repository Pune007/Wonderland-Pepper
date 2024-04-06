using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScript : MonoBehaviour
{
    [SerializeField] private Transform attackPoint;
    [SerializeField] private float attackRadius;
    [SerializeField] private LayerMask attackLayer;
    [SerializeField] private string attackInput;
    [SerializeField] private float moveWhere;
    [SerializeField] private Animator anim;
  
    void Update()
    {
        if (Input.GetButtonDown(attackInput))
        {
            Attack();
        }
    }

    void Attack()
    {
        anim.SetTrigger("Hit");
        Collider2D[] ballBye = Physics2D.OverlapCircleAll(attackPoint.position, attackRadius, attackLayer);
        foreach (Collider2D ball in ballBye)
        {
            Debug.Log("HIT" + ball.name);
            ball.GetComponent<BallinHehe>().UpMove(moveWhere);
        }
    }

    void OnDrawGizmos()
    {
        if (attackPoint == null)
            return;

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPoint.position, attackRadius);
    }
}
