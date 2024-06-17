using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ltem : MonoBehaviour
{

    private Animator animator;
    private AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        // �ڐG�����u�ԂɌĂ΂��
        animator.SetTrigger("Get");
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }


    private void OnTriggerStay(Collider other)
    {
       // �ڐG���Ă���ԂɌĂ΂��
       // Debug.Log("Stay");
    }

    private void OnTriggerExit(Collider other)
    {
       // ���ꂽ���ɌĂ΂��
      // Debug.Log("Exit");
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.Play();
    }
}
