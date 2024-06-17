using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ltem : MonoBehaviour
{

    private Animator animator;
    private AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        // ÚG‚µ‚½uŠÔ‚ÉŒÄ‚Î‚ê‚é
        animator.SetTrigger("Get");
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }


    private void OnTriggerStay(Collider other)
    {
       // ÚG‚µ‚Ä‚¢‚éŠÔ‚ÉŒÄ‚Î‚ê‚é
       // Debug.Log("Stay");
    }

    private void OnTriggerExit(Collider other)
    {
       // —£‚ê‚½‚ÉŒÄ‚Î‚ê‚é
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
