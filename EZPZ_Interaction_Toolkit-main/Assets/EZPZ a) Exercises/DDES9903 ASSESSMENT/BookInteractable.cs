using UnityEngine;
using TMPro;

public class BookInteractable : MonoBehaviour
{
    public TextMeshProUGUI promptText;

    public GameObject bookPanel;
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI ownerText;
    public TextMeshProUGUI descriptionText;

    public BookInteraction bookData;

    private bool playerNear = false;
    private bool panelOpen = false;

    void Start()
    {
        promptText.gameObject.SetActive(false);
        bookPanel.SetActive(false);
    }

    void Update()
    {
        if (playerNear && Input.GetKeyDown(KeyCode.E))
        {
            if (!panelOpen)
            {
                promptText.gameObject.SetActive(false);

                titleText.text = bookData.bookTitle;
                ownerText.text = "Owner: " + bookData.owner;
                descriptionText.text = bookData.description;

                bookPanel.SetActive(true);
                panelOpen = true;
            }
            else
            {
                bookPanel.SetActive(false);
                panelOpen = false;

                if (playerNear)
                    promptText.gameObject.SetActive(true);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;

            if (!panelOpen)
                promptText.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;

            promptText.gameObject.SetActive(false);
            bookPanel.SetActive(false);
            panelOpen = false;
        }
    }
}