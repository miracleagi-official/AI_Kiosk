using UnityEngine;
using UnityEngine.UI;

public class MainPanel : MonoBehaviour
{
    public PanelManager pm;
    public Button companyBtn;
    public Button productBtn;
    public Button departmentBtn;
    public Button locationBtn;

    public GameObject companyPanel;
    public GameObject productPanel;
    public GameObject departmentPanel;
    public GameObject locationPanel;
    
    void Start()
    {
        pm = PanelManager.instance;

        companyBtn.onClick.AddListener(() =>
        {
            Debug.Log("회사 소개 버튼 눌림");
            pm.OpenPanel(companyPanel);
        });

        productBtn.onClick.AddListener(() =>
        {
            Debug.Log("제품/서비스 버튼 눌림");
            pm.OpenPanel(productPanel);
        });

        departmentBtn.onClick.AddListener(() =>
        {
            Debug.Log("부서 안내 버튼 눌림");
            pm.OpenPanel(departmentPanel);
        });

        locationBtn.onClick.AddListener(() =>
        {
            Debug.Log("위치 안내 버튼 눌림");
            pm.OpenPanel(locationPanel);
        });
    }
}
