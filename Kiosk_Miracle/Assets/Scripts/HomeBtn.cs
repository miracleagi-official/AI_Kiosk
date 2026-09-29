using UnityEngine;
using UnityEngine.UI;

public class HomeBtn : MonoBehaviour
{
    public Button homeBtn;

    void Start()
    {
        homeBtn.onClick.AddListener(() =>
        {
            Debug.Log("홈 버튼 눌림");
            PanelManager.instance.GoHome();
        });
    }
}
