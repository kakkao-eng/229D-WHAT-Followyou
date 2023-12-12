using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnCollision1 : MonoBehaviour
{
    // เมื่อ Unity Player ชน Object นี้
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ตรวจสอบว่าเป็น Unity Player หรือ Object ที่ต้องการ
        if (collision.gameObject.CompareTag("Player"))
        {
            // สลับไปยังซีนที่ต้องการ (เปลี่ยน "ชื่อซีน" เป็นชื่อซีนที่ต้องการ)
            SceneManager.LoadScene("Scene5");
        }
    }
}

