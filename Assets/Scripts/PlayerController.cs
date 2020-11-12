using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform movePoint;

    //Start is called before the first frame
    void Start()
    {
        movePoint.parent = null;
    }

    // Update is called oncce per frame
    void Update()
    {
        if(Mathf.abs(Input.GetAxisRaw("Horizontal")) == 1f)
        {
            movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
        }

        if (Mathf.abs(Input.GetAxisRaw("Vertical")) == 1f)
        {
            movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
        }
    }
}
