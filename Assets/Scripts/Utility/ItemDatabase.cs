using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;
/*
namespace Utility
{
    [CreateAssetMenu(fileName = "ItemDatabase", menuName = "Game/Item Database")]
    public class ItemDatabase : ScriptableObject
    {
        public static ItemData[] Items;

        [Serializable]
        public struct ItemData
        {
            public string itemName;
            public int weight;
            public Sprite itemSprite; // Unity 에셋 (스프라이트)
            public AudioClip itemSound; // Unity 에셋 (오디오 클립)
            [TextArea(3, 10)]
            public string description;
        }

        public int GetPoolSize()
        {
            int length =  Items.Length;
            int poolSize = 0;
            for (int i = 0; i < length; i++)
            {
                poolSize += Items.ElementAt(i).weight;
            }

            return poolSize;
        }

        public void AddItem(string name, int weight, Sprite sprite, AudioClip sound, string desc)
        {
            ItemData[] newItems = new ItemData[Items.Length + 1];
            Array.Copy(Items, newItems, Items.Length);
            newItems[newItems.Length - 1] = new ItemData
            {
                itemName = name,
                weight = weight,
                itemSprite = sprite,
                itemSound = sound,
                description = desc
            };
            Items = newItems;
        }

        public void RemoveItem(int index)
        {
            if (index >= 0 && index < Items.Length)
            {
                ItemData[] newItems = new ItemData[Items.Length - 1];
                Array.Copy(Items, 0, newItems, 0, index);
                Array.Copy(Items, index + 1, newItems, index, Items.Length - index - 1);
                Items = newItems;
            }
        }

        public void ExportToCSV(string path)
        {
            StringBuilder csv = new StringBuilder();
            csv.AppendLine("ItemName,Weight,SpritePath,SoundPath,Description");

            foreach (var item in Items)
            {
                string spritePath = item.itemSprite != null ? AssetDatabase.GetAssetPath(item.itemSprite) : "";
                string soundPath = item.itemSound != null ? AssetDatabase.GetAssetPath(item.itemSound) : "";
                csv.AppendLine($"{item.itemName},{item.weight},{spritePath},{soundPath},{item.description}");
            }

            File.WriteAllText(path, csv.ToString());
        }

        public void ImportFromCSV(string path)
        {
            string[] lines = File.ReadAllLines(path);
            Items = new ItemData[lines.Length - 1]; // Minus 1 for header

            for (int i = 1; i < lines.Length; i++) // Skip header
            {
                string[] values = lines[i].Split(',');
                if (values.Length >= 5)
                {
                    Sprite sprite = AssetDatabase.LoadAssetAtPath<Sprite>(values[2]);
                    AudioClip sound = AssetDatabase.LoadAssetAtPath<AudioClip>(values[3]);
                    Items[i - 1] = new ItemData
                    {
                        itemName = values[0],
                        weight = int.Parse(values[1]),
                        itemSprite = sprite,
                        itemSound = sound,
                        description = values[4]
                    };
                }
            }
        }
    }
}*/