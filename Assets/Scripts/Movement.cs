using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody rb;
    private Transform tr;

    [SerializeField]
    public float thrust;

    [SerializeField]
    public float rotation;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(0f, Time.deltaTime*thrust, 0f);
        }
       
    }

    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rotate(rotation);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rotate(-rotation);
        }
    }

    private void rotate(float rotation)
    {
        rb.freezeRotation = true;
        tr.Rotate(0, 0, rotation * Time.deltaTime);
        rb.freezeRotation = false;
    }

}
