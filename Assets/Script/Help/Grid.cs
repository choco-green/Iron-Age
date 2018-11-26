using UnityEngine;

public class Grid : MonoBehaviour
{
    //The structure that is getting moved
    public GameObject Structure;
    
    //The Size of the grid
    public float GridSize = 1f;
    
    private Vector3 _beforeRounding;
    private Vector3 _roundedNumber;

    private void LateUpdate()
    {
        #region Getting the data from Raycast for "_beforeRounding"
        RaycastHit hit;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            _beforeRounding = hit.point;
        }
        #endregion

        //Rounding Up Number
        _roundedNumber.x = Mathf.RoundToInt(_beforeRounding.x / GridSize) * GridSize;
        _roundedNumber.y = 0;
        _roundedNumber.z = Mathf.RoundToInt(_beforeRounding.z / GridSize) * GridSize;
        
        //Setting the object's position to round up to grid
        Structure.transform.position = _roundedNumber;
    }
    
    
    /*
    public float Size { get { return size; } }

    public Vector3 GetNearestPointOnGrid(Vector3 Position)
    {
        Position -= transform.position;

        int XCount = Mathf.RoundToInt(Position.x / size);
        int YCount = Mathf.RoundToInt(Position.y / size);
        int ZCount = Mathf.RoundToInt(Position.z / size);
        return transform.TransformVector(XCount, YCount, ZCount);

    }
    */
}