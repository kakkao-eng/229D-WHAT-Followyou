using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    
    
    // ตัวแปรสำหรับ Player
    public GameObject playerPrefab;
    private GameObject playerInstance;

    public float minscaleY;
    public float maxscaleY;

    public string NextScene;

    // ตัวแปรสำหรับคะแนน
    private int score;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // เรียกฟังก์ชันเพื่อเริ่มเกม
        StartGame();
    }

    void StartGame()
    {
        
    }

    

    
}
