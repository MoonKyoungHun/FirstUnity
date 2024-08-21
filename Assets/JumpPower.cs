using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPower : MonoBehaviour
{
    public int jumpPower;

    Rigidbody rigidbody;

    public void Start()
    {
        rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    }
}
