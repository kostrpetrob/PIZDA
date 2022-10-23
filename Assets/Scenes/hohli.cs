using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hohli : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _jumpForce = 300;
    
    float RotFac = 15.0f;

    void Update() {
        var vel = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * _speed;
        vel.y = _rb.velocity.y;
        _rb.velocity = vel;
 
        if(Input.GetKeyDown(KeyCode.Space)) _rb.AddForce(Vector3.up * _jumpForce);
        Vector3 tolook;
        tolook.x = vel.x;
        tolook.z = vel.z;
        tolook.y = 0;
        Quaternion curRot = transform.rotation;
        Quaternion tarRot = Quaternion.LookRotation(tolook);
        transform.rotation = Quaternion.Slerp(curRot, tarRot, RotFac * Time.deltaTime);

    }
}

