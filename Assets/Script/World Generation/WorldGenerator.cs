using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
	//grid specifics
    [SerializeField] private int _rows;
    [SerializeField] private int _cols;
    [SerializeField] private Vector2 _gridSize;
    [SerializeField] private Vector2 _gridOffset;

    //about cells
    [SerializeField] private Sprite _cellSprite;
    private Vector2 _cellSize;
    private Vector2 _cellScale;

    private void Start ()
    {
        InitCells(); //Initialize all cells
	}

    private void InitCells() {
        var cellObject = new GameObject();

        //creates an empty object and adds a sprite renderer component -> set the sprite to cellSprite
        cellObject.AddComponent<SpriteRenderer>().sprite = _cellSprite;

        //catch the size of the sprite
        _cellSize = _cellSprite.bounds.size;

        //get the new cell size -> adjust the size of the cells to fit the size of the grid
        Vector2 newCellSize = new Vector2(_gridSize.x / (float)_cols, _gridSize.y / (float)_rows);

        //Get the scales so you can scale the cells and change their size to fit the grid
        _cellScale.x = newCellSize.x / _cellSize.x;
        _cellScale.y = newCellSize.y / _cellSize.y;

        _cellSize = newCellSize; //the size will be replaced by the new computed size, we just used cellSize for computing the scale

        cellObject.transform.localScale = new Vector2(_cellScale.x, _cellScale.y);

        //fix the cells to the grid by getting the half of the grid and cells add and minus experiment
        _gridOffset.x = -(_gridSize.x / 2) + _cellSize.x / 2;
        _gridOffset.y = -(_gridSize.y / 2) + _cellSize.y / 2;

        //fill the grid with cells by using Instantiate
        for (int row = 0; row < _rows; row++) {
            for (int col = 0; col < _cols; col++) {
                //add the cell size so that no two cells will have the same x and y position
                Vector2 pos = new Vector2(col * _cellSize.x + _gridOffset.x + transform.position.x, row * _cellSize.y + _gridOffset.y + transform.position.y);

                //instantiate the game object, at position pos, with rotation set to identity
                GameObject cO = Instantiate(cellObject, pos, Quaternion.identity) as GameObject;

                //set the parent of the cell to GRID so you can move the cells together with the grid;
                cO.transform.parent = transform;
            }
        }

        //destroy the object used to instantiate the cells
        Destroy(cellObject);
    }

    //so you can see the width and height of the grid on editor
    void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, _gridSize);
    }
}
