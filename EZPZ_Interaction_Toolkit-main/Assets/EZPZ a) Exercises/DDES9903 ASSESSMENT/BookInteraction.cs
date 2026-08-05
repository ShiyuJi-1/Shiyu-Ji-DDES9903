using UnityEngine;

public class BookInteraction : MonoBehaviour
{
    [Header("Book Information")]
    public string bookTitle;
    public string owner;

    [TextArea(3, 5)]
    public string description;

    public bool isPlayerBook = false;
}