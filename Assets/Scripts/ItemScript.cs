using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemScript : MonoBehaviour
{
    [SerializeField] private Image _icon;
    private ItemData _data;

    public ItemData Data => _data;

    public event Action<ItemData> Buy;

    public void Init(ItemData data)
    { 
        _data = data;
        _icon.sprite = _data.Icon;
    }

    public void ClickBuy()
    {
        Buy?.Invoke(_data);
    }
}
