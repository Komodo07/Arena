using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private void LateUpdate()
    {
        Rigidbody powerUpRb = GetComponent<Rigidbody>();

        powerUpRb.AddRelativeTorque(Vector3.forward, ForceMode.Force);
    }
}
