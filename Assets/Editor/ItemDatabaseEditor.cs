using System.Collections;
using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using Utility;
/*
[CustomEditor(typeof(ItemDatabase))]
public class ItemDatabaseEditor : Editor
{
    private ItemDatabase itemDB;
    private Vector2 scrollPosition;

    private void OnEnable()
    {
        itemDB = (ItemDatabase)target;
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.LabelField("Item Database", EditorStyles.boldLabel);
        EditorGUILayout.Space();

        // CSV 내보내기/가져오기 버튼
        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Export to CSV"))
        {
            string path = EditorUtility.SaveFilePanel("Save CSV", "", "ItemDatabase.csv", "csv");
            if (!string.IsNullOrEmpty(path))
            {
                itemDB.ExportToCSV(path);
                AssetDatabase.Refresh();
            }
        }
        if (GUILayout.Button("Import from CSV"))
        {
            string path = EditorUtility.OpenFilePanel("Open CSV", "", "csv");
            if (!string.IsNullOrEmpty(path))
            {
                itemDB.ImportFromCSV(path);
                EditorUtility.SetDirty(itemDB);
                AssetDatabase.SaveAssets();
            }
        }
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.Space();

        scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition);

        // 헤더
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Name", GUILayout.Width(100));
        EditorGUILayout.LabelField("Weight", GUILayout.Width(50));
        EditorGUILayout.LabelField("Sprite", GUILayout.Width(100));
        EditorGUILayout.LabelField("Sound", GUILayout.Width(100));
        EditorGUILayout.LabelField("Description", GUILayout.Width(200));
        EditorGUILayout.EndHorizontal();

        // 아이템 리스트
        for (int i = 0; i < ((ICollection)ItemDatabase.Items).Count; i++)
        {
            EditorGUILayout.BeginHorizontal();

            ItemDatabase.Items[i].itemName    = EditorGUILayout.TextField(ItemDatabase.Items[i].itemName, GUILayout.Width(100));
            ItemDatabase.Items[i].weight      = EditorGUILayout.IntField(ItemDatabase.Items[i].weight, GUILayout.Width(50));
            ItemDatabase.Items[i].itemSprite  = (Sprite)EditorGUILayout.ObjectField(ItemDatabase.Items[i].itemSprite, typeof(Sprite), false, GUILayout.Width(100));
            ItemDatabase.Items[i].itemSound   = (AudioClip)EditorGUILayout.ObjectField(ItemDatabase.Items[i].itemSound, typeof(AudioClip), false, GUILayout.Width(100));
            ItemDatabase.Items[i].description = EditorGUILayout.TextField(ItemDatabase.Items[i].description, GUILayout.Width(200));

            if (GUILayout.Button("Remove", GUILayout.Width(60)))
            {
                itemDB.RemoveItem(i);
                break;
            }

            EditorGUILayout.EndHorizontal();
        }

        EditorGUILayout.EndScrollView();

        // 새 아이템 추가 버튼
        if (GUILayout.Button("Add New Item"))
        {
            itemDB.AddItem("New Item", 1, null, null, "Description");
        }

        serializedObject.ApplyModifiedProperties();
    }
}*/