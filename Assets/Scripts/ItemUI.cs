using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    public Image itemImage;
    public Text itemName;
    public Text itemDescription;

    public void SetItem(Item item, bool collected)
    {
        itemImage.sprite = collected ? item.sprite : item.silhouette;
        itemName.text = collected ? item.name : "???";
        itemDescription.text = collected ? item.description : "아직 발견하지 못했습니다.";
        
        if (!collected)
        {
            itemImage.color = Color.gray;
            itemName.color = Color.gray;
            itemDescription.color = Color.gray;
        }
        else
        {
            itemImage.color = Color.white;
            itemName.color = Color.white;
            itemDescription.color = Color.white;
        }
    }
}
