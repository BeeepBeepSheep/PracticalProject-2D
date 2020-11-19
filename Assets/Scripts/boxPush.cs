using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPush : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform boxMovePoint;

    public LayerMask whatStopsMovement;

    // Start is called before the first frame update
    void Start()
    {
        boxMovePoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, boxMovePoint.position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, boxMovePoint.position) <= .05f)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                //checking if theres colliders
                if (!Physics2D.OverlapCircle(boxMovePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .5f, whatStopsMovement))
                {
                    boxMovePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                }
            }

            if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                if (!Physics2D.OverlapCircle(boxMovePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .5f, whatStopsMovement))
                {
                    boxMovePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                }
            }
        }
    }
}
