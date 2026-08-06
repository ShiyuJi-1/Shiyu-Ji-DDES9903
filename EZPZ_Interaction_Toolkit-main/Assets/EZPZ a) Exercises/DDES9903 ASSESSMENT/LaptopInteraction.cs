using UnityEngine;

public class LaptopInteraction1 : MonoBehaviour
{
    public GameObject laptopPanel;
    public GameObject inspectPrompt;

    private bool playerInRange = false;

    void Start()
    {
        if (laptopPanel != null)
            laptopPanel.SetActive(false);

        if (inspectPrompt != null)
            inspectPrompt.SetActive(false);
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (inspectPrompt != null)
                inspectPrompt.SetActive(false);

            if (laptopPanel != null)
                laptopPanel.SetActive(true);

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;

            if (inspectPrompt != null)
                inspectPrompt.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;

            if (inspectPrompt != null)
                inspectPrompt.SetActive(false);
        }
    }
}