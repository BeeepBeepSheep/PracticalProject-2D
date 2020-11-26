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
        //Debug.Log("box detected and should move virtical");

        if (Vector3.Distance(transform.position, boxMovePoint.position) <= .05f)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f); //else if make it so box doesent go diagonally
            {
                if (!Physics2D.OverlapCircle(boxMovePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .5f, WhatStopsBoxMovement))
                {
                    boxMovePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                }
            }
        }
    }
}