using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public Canvas yourCanvas; // ระบุ Canvas ที่คุณต้องการให้ผู้เล่นสามารถเปิดได้

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            yourCanvas.enabled = true; // เมื่อ Player โดน Trigger เข้าไปใน Collider นี้ Canvas จะถูกเปิด
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            yourCanvas.enabled = false; // เมื่อ Player ออกจาก Collider นี้ Canvas จะถูกปิด
        }
    }
}
