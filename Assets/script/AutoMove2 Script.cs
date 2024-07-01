using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove2Script : MonoBehaviour
{
    [SerializeField] private Transform Position;

    private float MoveSpeed = 4.0f;

    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, 17 + Mathf.Cos(Time.time) * MoveSpeed, transform.position.z);
    }
}
