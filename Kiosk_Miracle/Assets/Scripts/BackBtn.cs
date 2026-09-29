using UnityEngine;
using UnityEngine.UI;

public class BackBtn : MonoBehaviour
{
    public Button backBtn;
    void Start()
    {
        backBtn.onClick.AddListener(() =>
        {
            Debug.Log("뒤로가기 버튼 눌림");
            PanelManager.instance.GoBack();
        });
    }
}
