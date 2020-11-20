using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPush31 : MonoBehaviour
{
        public float moveSpeed = 5f;
    public Transform boxMovePoint;

    public LayerMask WhatStopsBoxMovement;

    // Start is called before the first frame update
    void Start()
    {
        boxMovePoint.parent = null;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("box detected and should move");
        transform.position = Vector3.MoveTowards(transform.position, boxMovePoint.position, moveSpeed * Time.deltaTime);   
    }
}
