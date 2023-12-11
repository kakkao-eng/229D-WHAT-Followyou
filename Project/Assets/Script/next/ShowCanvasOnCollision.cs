using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowCanvasOnCollision : MonoBehaviour
{
    public Canvas yourCanvas; // เลือก Canvas ที่ต้องการให้แสดง

    private bool canvasOpen = false; // เพิ่มตัวแปรเพื่อตรวจสอบว่า Canvas ถูกเปิดหรือยัง

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            yourCanvas.enabled = true; // เมื่อ Player เข้าไปใน Collider จะเปิด Canvas
            canvasOpen = true; // กำหนดให้ Canvas ถูกเปิด
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            yourCanvas.enabled = false; // เมื่อ Player ออกจาก Collider จะปิด Canvas
            canvasOpen = false; // กำหนดให้ Canvas ถูกปิด
        }
    }

    private void Update()
    {
        if (canvasOpen && Input.GetKeyDown(KeyCode.E))
        {
            ChangeCanvasScene(); // เรียกฟังก์ชันเมื่อ Canvas ถูกเปิดและกดปุ่ม E
        }
    }

    void ChangeCanvasScene()
    {
        // เปลี่ยนซีนโดยการโหลดซีนใหม่ด้วย SceneManager.LoadScene
        SceneManager.LoadScene("Scene3");

        // หรือถ้าต้องการเปลี่ยนการแสดงผลของ Canvas ที่มีอยู่ เช่นการเปลี่ยนภาพหรือข้อความบน Canvas ก็สามารถทำได้ดังนี้
        // yourCanvas.GetComponentInChildren<Text>().text = "ข้อความใหม่"; // ตัวอย่างการเปลี่ยนข้อความใน Text บน Canvas
        // yourCanvas.GetComponentInChildren<Image>().sprite = yourNewSprite; // เปลี่ยนภาพใน Image บน Canvas
    }
}