using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoveScript : MonoBehaviour
{
    private float MoveSpeed = 3.0f;
    void FixedUpdate()
    {
        transform.position = new Vector3(0,Mathf.Sin(Time.time) * MoveSpeed, 0);
    }
}
