using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private bool InventoryWindowToggle = false;
    private Rect InventoryWindowRect = new Rect(300, 100, 400, 400); 
    
    //Dictionary<int, ItemClass> InventoryNameDictionary = new Dictionary<int, Class>();
    static public Dictionary<int, string> InventoryNameDictionary = new Dictionary<int, string>()
    {
        {0, string.Empty},
        {1, string.Empty},
        {2, string.Empty},
        {3, string.Empty},
        {4, string.Empty},
        {5, string.Empty},
        {6, string.Empty},
        {7, string.Empty},
        {8, string.Empty},
        {9, string.Empty},
        {10, string.Empty},
        {11, string.Empty}
    };

    ItemClass itemObject = new ItemClass();

    void OnGUI()
    {
        InventoryWindowToggle = GUI.Toggle(new Rect(800, 50, 100, 50), InventoryWindowToggle, "Inventory");

        if (InventoryWindowToggle)
        {
            InventoryWindowRect = GUI.Window(0, InventoryWindowRect, InventoryWindowMethod, "Inventory");
        }
    }

    void InventoryWindowMethod(int WindowID)
    {
        GUILayout.BeginArea(new Rect(5, 50, 400, 400));

        GUILayout.BeginHorizontal();
        GUILayout.Button (InventoryNameDictionary[0] , GUILayout.Height(50));
        GUILayout.Button (InventoryNameDictionary[1], GUILayout.Height(50));
        GUILayout.Button (InventoryNameDictionary[2], GUILayout.Height(50));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Button (InventoryNameDictionary[3], GUILayout.Height(50));
        GUILayout.Button (InventoryNameDictionary[4], GUILayout.Height(50));
        GUILayout.Button (InventoryNameDictionary[5], GUILayout.Height(50));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Button (InventoryNameDictionary[6], GUILayout.Height(50));
        GUILayout.Button (InventoryNameDictionary[7], GUILayout.Height(50));
        GUILayout.Button (InventoryNameDictionary[8], GUILayout.Height(50));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Button (InventoryNameDictionary[9], GUILayout.Height(50));
        GUILayout.Button (InventoryNameDictionary[10], GUILayout.Height(50));
        GUILayout.Button (InventoryNameDictionary[11], GUILayout.Height(50));
        GUILayout.EndHorizontal();

        GUILayout.EndArea();
    }
}
