using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ltem : MonoBehaviour
{

    private Animator animator;


    private void OnTriggerEnter(Collider other)
    {
        // 接触した瞬間に呼ばれる
        animator.SetTrigger("Get");
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }


    private void OnTriggerStay(Collider other)
    {
       // 接触している間に呼ばれる
       // Debug.Log("Stay");
    }

    private void OnTriggerExit(Collider other)
    {
       // 離れた時に呼ばれる
      // Debug.Log("Exit");
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
