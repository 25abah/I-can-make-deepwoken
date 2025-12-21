using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public InputActionReference move;
    private Transform playerTransform;
    private Vector2 movingV2;
    private Vector3 movingV3;
    private Rigidbody rb;
    public int moveSpeed;

    private Animator animator;
    void Start()
    {
        playerTransform = gameObject.transform;
        rb = gameObject.GetComponent<Rigidbody>();
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movingV2 = move.action.ReadValue<Vector2>();
        movingV3 = new Vector3(movingV2.x * moveSpeed * Time.deltaTime,0,movingV2.y* moveSpeed * Time.deltaTime);
        if(movingV3.Equals(new Vector3(0,0,0)))
        {
            animator.SetBool("isWalking",false);
        }
        else
        {
            animator.SetBool("isWalking",true);
        }
    }
    void FixedUpdate()
    {
        playerTransform.position += movingV3;
    }

    private void moving(InputAction.CallbackContext context)
    {
       Debug.Log("context");
    }
}
