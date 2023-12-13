using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Image paperImage; // กำหนดภาพของกระดาษในส่วนของ Inspector
    public Button paperButton; // กำหนดปุ่ม Paper ในส่วนของ Inspector
    public Button nextButton; // กำหนดปุ่ม Next ในส่วนของ Inspector

    private bool isOpen = false;

    void Start()
    {
        // ปิด (ซ่อน) paperImage เมื่อเริ่มต้น
        paperImage.enabled = false;

        // ปิดปุ่ม Next เมื่อเริ่มต้น
        nextButton.gameObject.SetActive(false);

        // ตั้งค่าการเรียกใช้งานฟังก์ชัน OnClick สำหรับปุ่ม Paper
        paperButton.onClick.AddListener(OnPaperClick);
    }

    void OnPaperClick()
    {
        if (!isOpen) // ถ้ายังไม่เปิดอยู่
        {
            isOpen = true;
            paperImage.enabled = true;
            nextButton.gameObject.SetActive(true); // เปิดปุ่ม Next เพื่อให้แสดง
        }
    }
}