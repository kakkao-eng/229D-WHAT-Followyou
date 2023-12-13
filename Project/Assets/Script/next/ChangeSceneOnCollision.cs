using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnCollision : MonoBehaviour
{
    // เมื่อ Unity Player ชน Object นี้
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ตรวจสอบว่าเป็น Unity Player หรือ Object ที่ต้องการ
        if (collision.gameObject.CompareTag("Player"))
        {
            // สลับไปยังซีนที่ต้องการ (เปลี่ยน "ชื่อซีน" เป็นชื่อซีนที่ต้องการ)
            SceneManager.LoadScene("Scene");

            // เมื่อโหลดซีนเสร็จ กำหนดตำแหน่งและขนาดตัวละครใหม่
            SetCharacterPositionAndScale();
        }
    }

    // กำหนดตำแหน่งและขนาดตัวละครหลังจากโหลดซีนใหม่
    private void SetCharacterPositionAndScale()
    {
        // กำหนดตำแหน่งเริ่มต้นของตัวละครที่ต้องการ
        transform.position = new Vector3(-54.46f, 17.57f, 0f);

        // กำหนดขนาดของตัวละครที่ต้องการ
        transform.localScale = new Vector3(0.5304f, 0.5304f, 0.5304f);
    }
}


