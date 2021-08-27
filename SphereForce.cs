using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereForce : MonoBehaviour
{
    public float force = 90;
    public Rigidbody rb;
    public Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(new Vector3(0, force, 0), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0)
            Destroy(this.gameObject);
    }
}
