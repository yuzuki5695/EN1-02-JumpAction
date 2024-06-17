using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowDraw : MonoBehaviour
{
    [SerializeField]
    private Image arrowImage;
    private Vector3 clickPosititon; 
    // Start is called before the first frame update
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {     
        if (Input.GetMouseButtonDown(0))
        {
            clickPosititon = Input.mousePosition; 
            arrowImage.gameObject.SetActive(true);

        }       
        if (Input.GetMouseButton(0))
        {         
            Vector3 dist = clickPosititon - Input.mousePosition;
            // �x�N�g���̒������Z�o
            float size = dist.magnitude;
            // �x�N�g������p�x(�ϓx�@)���Z�o
            float angleRad = Mathf.Atan2(dist.y, dist.x);
            // ���̉摜���N���b�N�����ꏊ�ɉ摜���ړ�
            arrowImage.rectTransform.position = clickPosititon;
            // ���̉摜���x�N�g������Z�o�����p�x���ϓx�@�ɕϊ�����Z����]
            arrowImage.rectTransform.rotation
            = Quaternion.Euler(0, 0, angleRad * Mathf.Rad2Deg);
            // ���̉摜�̑傫�����h���b�N���������ɍ��킹��
            arrowImage.rectTransform.sizeDelta = new Vector2(size, size);
        }
        if (Input.GetMouseButtonUp(0))
        {
           arrowImage.gameObject.SetActive(false);
        }
    }
}
