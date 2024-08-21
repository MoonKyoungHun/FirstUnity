using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPower : MonoBehaviour
{
    public int jumpPower;

    public Rigidbody rigidbody;

    public void Start()
    {
        rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    }
}
