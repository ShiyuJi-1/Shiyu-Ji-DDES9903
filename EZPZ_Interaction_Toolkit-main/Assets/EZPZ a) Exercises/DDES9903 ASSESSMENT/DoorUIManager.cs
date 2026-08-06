using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorUIManager : MonoBehaviour
{
    public GameObject doorPanel;

    void Start()
    {
        if (doorPanel != null)
            doorPanel.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void OpenDoorMenu()
    {
        if (doorPanel != null)
            doorPanel.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        Time.timeScale = 0f;
    }

    public void CloseDoorMenu()
    {
        if (doorPanel != null)
            doorPanel.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        Time.timeScale = 1f;
    }

    // 返回 HOME
    public void GoToHome()
    {
        Time.timeScale = 1f;

        // 告诉 HOME：这是返回，不是第一次进入
        GameManager.ReturnedHome = true;

        SceneManager.LoadScene("HOME");
    }

    // 去教室
    public void GoToClassroom()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("CLASSROOM");
    }

    // 去 Lost and Found
    public void GoToLost()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("LOST AND FOUND");
    }
}