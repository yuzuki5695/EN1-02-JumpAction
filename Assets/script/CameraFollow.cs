using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;  // プレイヤーのTransform
    public Vector3 offset;    // プレイヤーとのオフセット距離
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        // カメラの位置をプレイヤーの位置＋オフセットに設定する
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
