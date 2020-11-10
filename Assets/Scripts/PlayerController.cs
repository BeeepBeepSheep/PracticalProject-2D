using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vPlayerController : MonoBehaviour
{

    public float moveSpeed = 9f;
    public Transform movePoint;
    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movepoint.position, moveSpeed* Time.deltaTime);

        if(Vector3.Distance(transform.position, movePoint.position) <= .05f)
        {
            if( Mathf.abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
            movePoint.position += new Vectore3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
            }

            if( Mathf.abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
            movePoint.position += new Vectore3(0f, Input.GetAxisRaw("Vertical"), 0f, 0f);
            }
        }
    }
}
