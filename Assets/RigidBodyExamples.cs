using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyExamples : MonoBehaviour
{
    public float force = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        // var colliders = Physics.OverlapSphere(transform.position, 2.0f);
        // foreach (var hit in colliders)
        // {
        //     var _rb = hit.GetComponent<Rigidbody>();
        //     if (_rb != null)
        //     {
        //         _rb.AddExplosionForce(10*force, transform.position, 10.0f);
        //     }
        // }

        var rb = GetComponent<Rigidbody>();
        rb.AddTorque(Vector3.right * force * 10);
        rb.AddForce(Vector3.one * force * 5 * Time.deltaTime, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
