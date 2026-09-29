using UnityEngine;
using UnityEngine.UI;

public class MapImage : MonoBehaviour
{
    public Button floor1btn;
    public Button floor2btn;
    public Button floor3btn;
    public Button floor4btn;

    public Texture2D[] mapImgs;
    public RawImage map;

    void Start()
    {
        floor1btn.onClick.AddListener(() =>
        {
            SwitchMapImg(0);
        });

        floor2btn.onClick.AddListener(() =>
        {
            SwitchMapImg(1);
        });

        floor3btn.onClick.AddListener(() =>
        {
            SwitchMapImg(2);
        });

        floor4btn.onClick.AddListener(() =>
        {
            SwitchMapImg(3);
        });
    }

    public void SwitchMapImg(int idx)
    {
        map.texture = mapImgs[idx];
    }
}
