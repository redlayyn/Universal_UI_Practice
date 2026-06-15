using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private List<ItemData> _data;
    [SerializeField] private ItemScript _prefab;
    [SerializeField] private Transform _content;
    [SerializeField] private PopupItemInfo _itemInfo; 


    private void Start()
    {
        foreach(ItemData item in _data)
        {
            ItemScript obj = Instantiate(_prefab, _content);
            obj.Init(item);
            obj.Buy += OnItemBuy;
        }
    }

    private void OnItemBuy(ItemData item)
    {
        _itemInfo.Open(item);
    }
}
