using UnityEngine;
using UnityEngine.UI;

public class MainBtn : MonoBehaviour
{
    public Button mainBtn;
    public GameObject welcome_panel;
    public GameObject main_panel;
    public GameObject navBar;
    
    void Start()
    {
        mainBtn.onClick.AddListener(() =>
        {
            PanelManager.instance.OpenPanel(main_panel);
            navBar.SetActive(true);
            welcome_panel.SetActive(false);
        });
    }
}
