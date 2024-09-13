using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// UI 관리자
public class UIManager : MonoBehaviour
{
    public GameManager gameManager;
    public Transform inventoryContent;
    public GameObject inventoryItemPrefab;
    public RectTransform inventoryPanel;
    public float openPosition = 0f;
    public float closedPosition = -1000f;
    public float animationDuration = 0.5f;

    private bool isInventoryOpen = false;

    private void Start()
    {
        UpdateInventory();
        CloseInventory();
    }

    public void UpdateInventory()
    {
        foreach (Transform child in inventoryContent)
        {
            Destroy(child.gameObject);
        }
        
        foreach (Item item in gameManager.itemDatabase.items)
        {
            GameObject itemObject = Instantiate(inventoryItemPrefab, inventoryContent);
            ItemUI itemUI = itemObject.GetComponent<ItemUI>();
            
            itemUI.SetItem(item, gameManager.HasCollectedItem(item.name));
        }
    }

    public void ToggleInventory()
    {
        if (isInventoryOpen)
        {
            CloseInventory();
        }
        else
        {
            OpenInventory();
        }
    }

    private void OpenInventory()
    {
        isInventoryOpen = true;
        inventoryPanel.LeanMoveY(openPosition, animationDuration).setEaseOutQuad();
    }

    private void CloseInventory()
    {
        isInventoryOpen = false;
        inventoryPanel.LeanMoveY(closedPosition, animationDuration).setEaseInQuad();
    }
}
