using UnityEngine;
using UnityEngine.UI;

public class testHref : MonoBehaviour
{
    private LinkImageText textPic;

    void Awake()
    {
        textPic = GetComponent<LinkImageText>();
    }

    void OnEnable()
    {
        textPic.onHrefClick.AddListener(OnHrefClick);
    }

    void OnDisable()
    {
        textPic.onHrefClick.RemoveListener(OnHrefClick);
    }

    private void OnHrefClick(string hrefName)
    {
        Text text = GameObject.Find("TextResult").GetComponent<Text>();
        text.text = "点击了" + hrefName;
        Debug.Log("点击了 " + hrefName);
    }
}
