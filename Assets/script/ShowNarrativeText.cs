using UnityEngine;
using TMPro;
using UnityEngine.UI; // 需要引入这个才能操作 Button

public class ShowNarrativeText : MonoBehaviour
{
    public TextMeshProUGUI narrativeText;  // Narrative Text 组件
    public string[] textLines;             // 要显示的文本内容数组
    public Button closeButton;             // 关闭按钮引用

    private int currentIndex = 0;

    void Start()
    {
        narrativeText.gameObject.SetActive(true);
        narrativeText.text = "";
        closeButton.gameObject.SetActive(false); // 一开始隐藏关闭按钮
    }

    public void OnClickShowNext()
    {
        if (currentIndex < textLines.Length)
        {
            narrativeText.text = textLines[currentIndex];
            currentIndex++;

            // ✅ 如果现在显示的是最后一段，开启关闭按钮
            if (currentIndex == textLines.Length)
            {
                closeButton.gameObject.SetActive(true);
            }
        }
    }

    public void OnClickClose()
    {
        narrativeText.gameObject.SetActive(false);
        closeButton.gameObject.SetActive(false);
        currentIndex = 0;
    }
}
