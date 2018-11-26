using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class ItemPlacer : MonoBehaviour
{
    private Grid grid;

    private void Awake()
    {
        grid = FindObjectOfType<Grid>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit HitInfo;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out HitInfo))
            {
                PlaceCubeNear(HitInfo.point);
            }
        }
    }
    private void PlaceCubeNear(Vector3 ClickPoint)
    {
        var FinalPosition = grid.GetNearestPointOnGrid(ClickPoint);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = FinalPosition;
    }
}*/
