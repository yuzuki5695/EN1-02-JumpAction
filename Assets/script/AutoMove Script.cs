using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoveScript : MonoBehaviour
{
    [SerializeField] private Transform Position;

    private float MoveSpeed = 2.0f;
    
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, 8 + Mathf.Cos(Time.time) * MoveSpeed, transform.position.z);
    }

}