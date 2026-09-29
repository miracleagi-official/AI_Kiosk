using UnityEngine;

public class MapDropdown : MonoBehaviour
{
    public CustomDropdown dropdown;
    public MapImage mapImage;
    void Start()
    {
        if(mapImage == null) mapImage = GetComponent<MapImage>();
        
        if(mapImage == null) 
        {
            Debug.Log("mapImage 컴포넌트 비어있음");
            return;
        }

        dropdown.onValueChanged.AddListener((index) =>
        {
            // 나중에 서버 연동 시 활용하기 위한 변수
            string selectedName = dropdown.options[index].text;

            switch(index)
            {
                case 0:
                    Debug.Log("대표실 클릭");
                    mapImage.SwitchMapImg(2);
                    break;
                
                case 1:
                    Debug.Log("경영 총괄 클릭");
                    mapImage.SwitchMapImg(2);
                    break;
                
                case 2:
                    Debug.Log("AI/SW 연구개발 클릭");
                    mapImage.SwitchMapImg(1);
                    break;
                
                case 3:
                    Debug.Log("LMS 클릭");
                    mapImage.SwitchMapImg(2);
                    break;
                
                case 4:
                    Debug.Log("콘텐츠 연구 개발 클릭");
                    mapImage.SwitchMapImg(2);
                    break;
                
                case 5:
                    Debug.Log("교육 운영 홍보 클릭");
                    mapImage.SwitchMapImg(2);
                    break;

                case 6:
                    Debug.Log("화장실 클릭");
                    break;
            }
        });
    }
}
