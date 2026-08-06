using UnityEngine;

[RequireComponent(typeof(BookInteraction))]
public class BookPickup : MonoBehaviour
{
    private BookInteraction bookData;

    private void Awake()
    {
        bookData = GetComponent<BookInteraction>();

        if (bookData == null)
        {
            Debug.LogError(
                "BookPickup 找不到 BookInteraction，请确认两个脚本挂在同一本书上。",
                this
            );
        }
    }

    private void OnMouseDown()
    {
        if (bookData == null)
            return;

        if (bookData.isPlayerBook)
        {
            Debug.Log("You picked up your book!");

            GameManager.HasBook = true;

            gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("This book belongs to someone else.");
        }
    }
}