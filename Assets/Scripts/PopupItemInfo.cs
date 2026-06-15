using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupItemInfo : MonoBehaviour
{
    [SerializeField] private Image _icon;
    [SerializeField] private TMP_Text _text;

    public void Open(ItemData data)
    {
        _icon.sprite = data.Icon;
        _text.text = data.Description;
        gameObject.SetActive(true);
    }
}
