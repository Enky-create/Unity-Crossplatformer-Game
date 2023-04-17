using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    public static GameInput Instance { get; private set; }
    private PlayerInputActions playerInputActions;
    private void Awake()
    {
        
        if (Instance!=null)
        {
            Debug.LogError("GameInput already exists");
        }
        Instance = this;
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
    }
    private void OnDestroy()
    {
        playerInputActions.Dispose();
    }
    public Vector2 GetInputVectorNormalized()
    {
        Vector2 inputVector = playerInputActions.Player.Movement.ReadValue<Vector2>();
        return inputVector.normalized;
    }
}
