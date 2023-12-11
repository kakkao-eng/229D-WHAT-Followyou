using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneNameToLoad; // ชื่อของฉากที่ต้องการโหลด

    public void LoadSceneOnClick()
    {
        SceneManager.LoadScene(sceneNameToLoad); // โหลดฉากที่ต้องการ
    }
}

