using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float mHorizontal;
    private float mVertical;

    private Rigidbody rb;

    public float velocity;
    public float jumpForce;

    private Vector3 jumpV;

    public bool isGrounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (velocity <= 0) velocity = 25f;
        if (jumpForce <= 0) jumpForce = 2f;

        jumpV = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionEnter() {

        isGrounded = true;
    }
     
      private void FixedUpdate(){
        mHorizontal = Input.GetAxis("Horizontal");
        mVertical = Input.GetAxis("Vertical");

        print(" " + mVertical + ", " + mHorizontal);

        Movement(mHorizontal, mVertical);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(jumpV * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void Movement(float HInput, float VInput) {
        transform.Translate(Vector3.forward * VInput * velocity * Time.deltaTime);
        transform.Translate(Vector3.right * HInput * velocity * Time.deltaTime);
    }

}
