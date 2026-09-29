using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public static PanelManager instance;

    private Stack<GameObject> panelHistory = new Stack<GameObject>();
    public GameObject main_panel;
    public GameObject navBar;
    public TMP_Text dateText;

    [Header("초기 화면")]
    public GameObject adScreen;
    public GameObject welcomeScreen;

    [Header("모든 패널 목록")]
    public GameObject[] allPanels;

    private float timer = 0f;
    void Awake()
    {
        instance = this;

        foreach(var panel in allPanels)
            panel.SetActive(false);

        adScreen.SetActive(true);
        welcomeScreen.SetActive(false);
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 1f)
        {
            timer = 0f;
            dateText.text = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");
        }        
    }

    /// <summary>
    /// 광고 화면 띄우기
    /// </summary>
    public void GoAd()
    {
        while(panelHistory.Count > 0)
            panelHistory.Pop().SetActive(false);

        main_panel.SetActive(false);
    }

    /// <summary>
    /// 새 창 띄울 때 사용
    /// </summary>
    /// <param name="newPanel"></param>
    public void OpenPanel(GameObject newPanel)
    {
        if(panelHistory.Count > 0)
            panelHistory.Peek().SetActive(false);

        newPanel.SetActive(true);
        panelHistory.Push(newPanel);
    }

    /// <summary>
    /// 뒤로가기 버튼용. 이전 패널로 돌아감
    /// </summary>
    public void GoBack()
    {
        if(panelHistory.Count <= 1) return;

        panelHistory.Pop().SetActive(false);
        panelHistory.Peek().SetActive(true);
    }

    /// <summary>
    /// 홈 버튼용. 메인으로 돌아감
    /// </summary>
    public void GoHome()
    {
        while(panelHistory.Count > 0)
            panelHistory.Pop().SetActive(false);

        main_panel.SetActive(true);
        panelHistory.Push(main_panel);
    }
}
