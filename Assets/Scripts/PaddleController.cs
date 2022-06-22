using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed;

    public KeyCode leftKey;
    public KeyCode rightKey;

    private Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = GetInput();

        rig.velocity = movement;
    }

    private Vector3 GetInput()
    {
        if (Input.GetKey(leftKey))
        {
            return speed * -transform.right;
        }

        if (Input.GetKey(rightKey))
        {
            return transform.right * speed;
        }

        return Vector3.zero;
    }
}
