﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPush2 : MonoBehaviour
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

//---------------------------------------------
//---------------------------------------------
//----------------------------------------------
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class BoxPush1 : MonoBehaviour
//{
//    public float moveSpeed = 5f;
//    public Transform boxMovePoint;

//    public LayerMask WhatStopsBoxMovement;

//    // Start is called before the first frame update
//    void Start()
//    {
//        boxMovePoint.parent = null;
//    }

//    private void OnTriggerEnter2D(Collider2D other)
//    {
//        Debug.Log("Hit before");
//        transform.position = Vector3.MoveTowards(transform.position, boxMovePoint.position, moveSpeed * Time.deltaTime);

//        if (Vector3.Distance(transform.position, boxMovePoint.position) <= .05f)
//        {
//            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
//            {
//                //checking if theres colliders
//                if (!Physics2D.OverlapCircle(boxMovePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .5f, WhatStopsBoxMovement))
//                {
//                    boxMovePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
//                }
//            }
//            else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f) ; //else if make it so box doesent go diagonally
//            {
//                if (!Physics2D.OverlapCircle(boxMovePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .5f, WhatStopsBoxMovement))
//                {
//                    boxMovePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
//                }
//            }
//        }
//        Debug.Log("Hit after");

//    }
//}
