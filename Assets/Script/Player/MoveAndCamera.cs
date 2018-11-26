using UnityEngine;

public class MoveAndCamera : MonoBehaviour
{
    public GameObject Player;

    #region Camera Variables
    Camera MainCamera;  //place holder for camera...
    public float yCCDelta;  //<<< (y = y_axis)(CC = CameraController)
    public float CCMoveSpeed = 150f;    //maxium speed for camera to move
    #endregion

    #region Movement Variables
    //Variable for Movement//
    public float xMCDelta;  //<<< (x = x_axis) (MC = MovementController)
    public float zMCDelta;  //<<< (z = z_axis) (MC = MovementController)
    public float MCMoveSpeed = 100f;  //maxium speed for player to move
#endregion
     
    void Start()
    {
        //Camera Check//
        MainCamera = Camera.main;   //Assign MainCamera to the MainCamera in the scene
        MainCamera.enabled = true;
    }

    void Update()
    {
        MovmentController();
        CameraController();
    }

    void MovmentController()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) 
        {
            xMCDelta = Input.GetAxis("Horizontal") * Time.deltaTime * MCMoveSpeed;  //KEY"A" AND KEY"D" * Time is held * MoveSpeed(set on top)
            zMCDelta = Input.GetAxis("Vertical")  *  Time.deltaTime * MCMoveSpeed;  //KEY"W" AND KEY"S" * Time is held * MoveSpeed(set on top)
            Player.transform.Translate(xMCDelta, 0, zMCDelta); //Update on where the "player" should go
        }
        else
        {
            xMCDelta = 0;
            zMCDelta = 0;
        }
    }
    
    void CameraController()
    {
        //yCCDelta = Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * CCMoveSpeed;   //MouseButton"ScrollWheel" * Time is held * MoveSpeed(set on top)
        Vector3 newPos = new Vector3(Player.transform.position.x, Player.transform.position.y + 10, Player.transform.position.z);
        MainCamera.transform.position = newPos;
    }
}