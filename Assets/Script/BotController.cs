using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BotController : MonoBehaviour
{
    public float speed = 10;
    public float rotation = 50;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var forwardInput = Input.GetAxis("Vertical");
        var rotationInput = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.W)) {
            animator.SetBool("isWalking", true);
        transform.Translate(Vector3.forward *Time.deltaTime * speed * forwardInput);
        }
        
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("isWalking", true);
            transform.Rotate(Vector3.up * Time.deltaTime * rotation * rotationInput);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("isWalking", true);
            transform.Rotate(Vector3.up * Time.deltaTime * rotation * rotationInput);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isWalking", true);
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        }



        else
        {
            animator.SetBool("isWalking", false);
        }



    }
}
