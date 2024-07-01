using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;  // �v���C���[��Transform
    public Vector3 offset;    // �v���C���[�Ƃ̃I�t�Z�b�g����
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        // �J�����̈ʒu���v���C���[�̈ʒu�{�I�t�Z�b�g�ɐݒ肷��
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
