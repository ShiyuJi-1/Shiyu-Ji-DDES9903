using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool HasBook = false;

    // 是否是从其他场景返回 HOME
    public static bool ReturnedHome = false;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}