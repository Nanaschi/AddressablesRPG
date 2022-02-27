using UnityEngine;
using UnityEngine.UI;

public class InventoryDisplay : MonoBehaviour
{
    [SerializeField] private Image[] _hotbarSlots;

    public Image[] HotbarSlots
    {
        get => _hotbarSlots;
        set => _hotbarSlots = value;
    }


    [SerializeField] private GameObject _inventoryDisplayHolder;
    
    public GameObject InventoryDisplayHolder
    {
        get => _inventoryDisplayHolder;
        set => _inventoryDisplayHolder = value;
    }
}