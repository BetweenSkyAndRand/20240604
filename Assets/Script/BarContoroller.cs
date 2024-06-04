using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BarContorller : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody myRigitbody;

    // Start is called before the first frame update
    void Start()
    {
        myRigitbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        myRigitbody.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, 0f, 0f);
    }
}
