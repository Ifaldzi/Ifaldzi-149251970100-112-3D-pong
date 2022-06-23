using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;
    public Vector3 direction;

    private Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "Ground")
        {
            rig.AddForce(rig.velocity.normalized * speed, ForceMode.VelocityChange);
            //rig.velocity = rig.velocity.normalized * 10f;
        }
    }

    public void SetVelocity(Vector3 direction)
    {
        GetComponent<Rigidbody>().velocity = direction * speed;
    }
}
