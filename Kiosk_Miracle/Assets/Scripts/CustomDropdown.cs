using UnityEngine;
using TMPro;

public class CustomDropdown : TMP_Dropdown
{
    private string placeholderText = "";
    private bool isSelected = false;

    protected override void Awake()
    {
        base.Awake();
        if (captionText != null)
            captionText.text = placeholderText;

        onValueChanged.AddListener((index) => {
            isSelected = true;
        });
    }

    void Update()
    {
        if (!isSelected && captionText != null && captionText.text != placeholderText)
            captionText.text = placeholderText;
    }
}