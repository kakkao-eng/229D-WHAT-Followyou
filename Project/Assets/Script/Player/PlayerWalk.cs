using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerWalk : MonoBehaviour
{
    private Rigidbody2D rb2D; // Reference to Rigidbody2D component
    private Animator animator;
    public float speed;
    private bool isWalking;

    // ประกาศตัวแปรเพิ่มสำหรับขนาดของตัวละคร
    public float minYScale;
    public float maxYScale;
    public float minMaxScaleXYZ;
    public float scaleChangeSpeed; // เพิ่มความเร็วในการเปลี่ยนขนาด

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component
        if (rb2D != null)
        {
            rb2D.gravityScale = 0f; // Disable gravity for the character
        }

        animator = GetComponent<Animator>();

        minYScale = GameManager.instance.minscaleY;
        maxYScale = GameManager.instance.maxscaleY;
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveX, moveY, 0f).normalized * speed * Time.deltaTime;
        transform.Translate(movement);

        // ปรับขนาดตัวละครตามแกน Y, X, Z ด้วยความเร็วที่ลดลง
        if (moveY > 0)
        {
            float newScale = Mathf.Lerp(transform.localScale.y, minYScale, Time.deltaTime * scaleChangeSpeed);
            transform.localScale = new Vector3(newScale, newScale, newScale);
        }
        else if (moveY < 0)
        {
            float newScale = Mathf.Lerp(transform.localScale.y, maxYScale, Time.deltaTime * scaleChangeSpeed);
            transform.localScale = new Vector3(newScale, newScale, newScale);
        }

        if (moveX != 0 || moveY != 0)
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



    void FlipSprite(float moveInput)
    {
        Debug.Log(moveInput);
        if (moveInput > 0.01f)
        {
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        else if (moveInput < -0.01f)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
    }




}
