using UnityEngine;

public class CloseLaptopPanel : MonoBehaviour
{
    public GameObject laptopPanel;

    public void ClosePanel()
    {
        laptopPanel.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
