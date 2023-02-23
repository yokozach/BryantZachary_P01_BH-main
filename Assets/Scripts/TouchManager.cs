using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TouchManager : MonoBehaviour
{
    
    [SerializeField]private GameObject player;
    private PlayerInput playerInput;
    private InputAction touchPosistionAction;
    private InputAction touchPressAction;
    private Vector3 touchPosition;
    Vector2 initialTouchPosition;
    private Camera cam;
    private bool isTouching = false;
   

    void Awake()
    {
     
        playerInput = GetComponent<PlayerInput>();

        //touchPressAction = playerInput.actions.FindAction("DragAndMove");
        //touchPosistionAction = playerInput.actions.FindAction("DragAndMove");
        
    }

    private void OnEnable()
    {

        //touchPressAction.performed += TouchPressed;
        var dragAndMoveAction = playerInput.actions.FindAction("DragAndMove");
        dragAndMoveAction.Enable();
        dragAndMoveAction.performed += TouchPressed;
        //playerInput.actions.FindAction("DragAndMove").performed += TouchPressed;

    }

    private void OnDisable()
    {
        //touchPressAction.performed -= TouchPressed;
        playerInput.actions.FindAction("DragAndMove").performed -= TouchPressed;
    }


    private void TouchPressed(InputAction.CallbackContext context)
    {

        Debug.Log("isTouching == true");
        Debug.Log(context);
        if (context.started)

            isTouching = true;
        else if (context.canceled)
            isTouching = false;

    }

    private void Update()
    {
        if (isTouching== true)
        {
            // touchPosition = cam.ScreenToWorldPoint(touchPosistionAction.ReadValue<Vector2>());
            //transform.position = touchPosition; 
            Debug.Log("isTouching == true");

        }
       
    }
}
