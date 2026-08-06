using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public DoorUIManager doorUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorUI.OpenDoorMenu();
        }
    }
}