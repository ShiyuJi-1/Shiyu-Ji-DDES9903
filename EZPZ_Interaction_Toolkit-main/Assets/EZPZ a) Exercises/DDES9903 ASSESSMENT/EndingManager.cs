using UnityEngine;

public class EndingManager : MonoBehaviour
{
    public GameObject endingSuccess;
    public GameObject endingFail;

    void Start()
    {
        endingSuccess.SetActive(false);
        endingFail.SetActive(false);

        // 第一次进入 HOME，不显示结局
        if (!GameManager.ReturnedHome)
            return;

        // 回到 HOME 后，根据是否拿到书显示不同结局
        if (GameManager.HasBook)
        {
            endingSuccess.SetActive(true);
        }
        else
        {
            endingFail.SetActive(true);
        }

        // 显示一次后恢复，避免再次进入 HOME 还显示
        GameManager.ReturnedHome = false;
    }
}