/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    private Rect InventoryWindowRect = new Rect(300, 100, 400, 400);
    private bool InventoryWindowShow = false;

    private Dictionary<int, string> CollectDictionary = new Dictionary<int, string>()
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
        {11, string.Empty},
        {12, string.Empty}
    };
    ItemClass ItemObject = new ItemClass();

    private Ray MouseRay;
    private RaycastHit RayHit;

    void Start()
    {
        //Display Dictionary
        CollectDictionary[0] = ItemObject.SciencePack1Item.Name;
        CollectDictionary[1] = ItemObject.SciencePack2Item.Name;
    }

    void Update()
    {
        MouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetButtonDown("Fire1"))
        {
            Physics.Raycast(MouseRay, out RayHit);
            if(RayHit.collider.transform.tag == "Chest")
            {
            InventoryWindowShow = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            InventoryWindowShow = false;
        }
    }

    void OnGUI()
    {
        if (InventoryWindowShow)
        {
            InventoryWindowRect = GUI.Window(0, InventoryWindowRect, InventoryWindowMethod, "Chest");
        }
    }

    void InventoryWindowMethod(int WindowID)
    {
        GUILayout.BeginArea(new Rect(0, 50, 400, 400));
        GUILayout.BeginHorizontal();

        if(GUILayout.Button(CollectDictionary[0], GUILayout.Height(50)))
        {
            if (CollectDictionary[0] != string.Empty)
            {



            }
        }
    }
}
*/