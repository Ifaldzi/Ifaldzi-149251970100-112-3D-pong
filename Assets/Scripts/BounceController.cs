using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceController : MonoBehaviour
{
    public float bounceForce;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody rig = collision.rigidbody;

            Vector3 direction = rig.velocity.normalized;
            rig.AddForce(new Vector3(direction.x, 0, direction.y) * bounceForce, ForceMode.VelocityChange);
        }
    }
}
