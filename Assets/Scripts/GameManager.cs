using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 아이템 클래스
[System.Serializable]
public class Item
{
    public string name;
    public int weight;
    public Sprite sprite;
    public Sprite silhouette;
    public string description;
}

[CreateAssetMenu(fileName = "New Item Database", menuName = "Inventory/Item Database")]
public class ItemDatabase : ScriptableObject
{
    public List<Item> items = new List<Item>();

    public Item GetItem(string itemName)
    {
        return items.Find(item => item.name == itemName);
    }
}

public class GameManager : MonoBehaviour
{
    public ItemDatabase itemDatabase;
    public HashSet<string> collectedItemNames = new HashSet<string>();
    public UIManager uiManager;

    public int minTapCount = 5;  // 최소 탭 횟수
    public int maxTapCount = 20; // 최대 탭 횟수

    private int currentTapCount = 0;
    public bool HasCollectedItem(string itemName)
    {
        return collectedItemNames.Contains(itemName);
    }

    public void TryCollectItem()
    {
        currentTapCount++;

        if (currentTapCount <= minTapCount)
        {
            Debug.Log("아직 아이템을 얻을 수 없습니다.");
            return;
        }
        float dropChance = Mathf.Clamp01((float)(currentTapCount - minTapCount) / (maxTapCount - minTapCount));

            if (Random.value <= dropChance)
            {
                Item collectedItem = GetRandomItem();
                collectedItemNames.Add(collectedItem.name);
            Debug.Log($"아이템 획득: {collectedItem.name}");
                uiManager.UpdateInventory();
            currentTapCount = 0; // 아이템을 얻었으므로 카운트 리셋
            }
            else
            {
            Debug.Log("이번에는 아이템을 얻지 못했습니다.");
            }

        if (currentTapCount >= maxTapCount)
        {
            Item collectedItem = GetRandomItem();
            collectedItemNames.Add(collectedItem.name);
            Debug.Log($"최대 횟수 도달! 아이템 획득: {collectedItem.name}");
            uiManager.UpdateInventory();
            currentTapCount = 0; // 아이템을 얻었으므로 카운트 리셋
        }
    }

    private Item GetRandomItem()
    {
        int totalWeight = 0;
        foreach (Item item in itemDatabase.items)
        {
            totalWeight += item.weight;
        }

        int randomValue = Random.Range(0, totalWeight);
        int weightSum = 0;

        foreach (Item item in itemDatabase.items)
        {
            weightSum += item.weight;
            if (randomValue < weightSum)
            {
                return item;
            }
        }

        return itemDatabase.items[itemDatabase.items.Count - 1];
    }
}
