using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullingJump : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 clickPosition;
    [SerializeField]
    private float jumpPower = 50;
    private bool isCanJump;
    // Start is called before the first frame update
    private AudioSource audioSource;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        Physics.gravity = new Vector3(0, -12.0f, 0);
        // rb = GetComponent<Rigidbody>(); //gameObject�͏ȗ��\
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickPosition = Input.mousePosition;
        }
        if (isCanJump && Input.GetMouseButtonUp(0))
        {     
            // �N���b�N�������W�Ɨ��������W�̍������擾
            Vector3 dist = clickPosition - Input.mousePosition;
            // �N���b�N�ƃ����[�X���������W�Ȃ�Ζ���
            if(dist.sqrMagnitude == 0) { return; }
            // ������W�������AjumpPower���������킹���l���ړ��ʂƂ���B
            rb.velocity = dist.normalized * jumpPower;

            audioSource.Play();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("�Փ˂���");
    }
    private void OnCollisionStay(Collision collision)
    {
        //Debug.Log("�ڐG��");

        // �Փ˂��Ă���_�̏�񂪕����i�[����Ă���
        ContactPoint[] contacts = collision.contacts;
        // 0�Ԗڂ̏Փˏ�񂩂�A�Փ˂��Ă���_�̖@�����擾�B
        Vector3 otherNormal = contacts[0].normal;
        // ������������x�N�g���B������1
        Vector3 upVector = new Vector3(0, 1, 0);
        // ������Ɩ@���̓��ρB2�̃x�N�g���͂Ƃ��ɒ�����1�Ȃ̂ŁAcos0�̌��ʂ�dotUN�ϐ��ɓ���B
        float dotUN = Vector3.Dot(upVector, otherNormal);
        // ���ϒl�ɋt�O�p�`�֐�arccos���|���Ċp�x���Z�o�B�����x���@�֕ϊ�����B����Ŋp�x���Z�o�ł����B
        float dotDeg = Mathf.Acos(dotUN) * Mathf.Rad2Deg;
        // ��̃x�N�g�����Ȃ��p�x��45�x��菬������΍ĂуW�����v�\�Ƃ���B
        if(dotDeg <= 45)
        {
            isCanJump = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        //Debug.Log("���E����");
        isCanJump = false;
    }
}
