using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public float speed = 5;
    Rigidbody myrigidbody;
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbodyにアクセスして変数に保持しておく
        myrigidbody = GetComponent<Rigidbody>();
        //右斜めに45度に進む
        myrigidbody.velocity = new Vector3(speed, speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
