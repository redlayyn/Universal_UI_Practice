using UnityEngine;

[CreateAssetMenu(fileName = "new item data", menuName = "ScriptableObjects/item data")]
public class ItemData : ScriptableObject
{
    [SerializeField] private Sprite _icon;
    [SerializeField] private string _description;

    public Sprite Icon => _icon;
    public string Description => _description;
}
