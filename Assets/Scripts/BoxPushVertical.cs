using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPushVertical : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform boxMovePoint;

    public LayerMask WhatStopsBoxMovement;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("box detected and should move horizontal");

        if (Vector3.Distance(transform.position, boxMovePoint.position) <= .05f)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                //checking if theres colliders
                if (!Physics2D.OverlapCircle(boxMovePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .5f, WhatStopsBoxMovement))
                {
                    boxMovePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                }
            }
        }
    }
}