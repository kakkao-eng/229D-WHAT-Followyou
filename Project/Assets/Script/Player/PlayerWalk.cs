using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerWalk : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    public float speed;
    private bool isWalking;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");

        if (SceneManager.GetActiveScene().name == "Scene4")
        {
            float moveX = Input.GetAxisRaw("Horizontal");
            float moveY = Input.GetAxisRaw("Vertical"); // เพิ่มการรับค่าแกน Y

            // ควบคุมการเคลื่อนที่แกน X ด้วย Rigidbody
            rb.velocity = new Vector2(moveX * speed, rb.velocity.y);

            // กำหนดการเคลื่อนที่โดยการเปลี่ยนตำแหน่งในแกน Y โดยไม่ใช้ Rigidbody
            float newYPosition = transform.position.y + (moveY * speed * Time.deltaTime);
            transform.position = new Vector3(transform.position.x, newYPosition, transform.position.z);

            // ตรวจสอบการเคลื่อนที่แกน Y เพื่อเปิด/ปิด Animator
            if (moveX != 0 || moveY != 0) // เมื่อมีการเคลื่อนที่ทั้งแกน X และ Y
            {
                isWalking = true;
                animator.SetBool("isWalking", isWalking);
                FlipSprite(moveX);
            }
            else
            {
                isWalking = false;
                animator.SetBool("isWalking", isWalking);
            }
        }
        
        else
        {
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

            if (moveInput != 0)
            {
                isWalking = true;
                animator.SetBool("isWalking", isWalking);
                FlipSprite(moveInput);
            }
            else
            {
                isWalking = false;
                animator.SetBool("isWalking", isWalking);
            }
        }

    }

    void FlipSprite(float moveInput)
    {
        if (moveInput > 0)
        {
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        else if (moveInput < 0)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
    }

}