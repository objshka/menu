using UnityEngine;
using UnityEngine.UI;

public class ButtonColorChanger : MonoBehaviour
{
    private Button _button;

    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(ChangeColor);
    }

    void ChangeColor()
    {
        ColorBlock cb = _button.colors;
        cb.pressedColor = Color.red;
        _button.colors = cb;
    }

}
