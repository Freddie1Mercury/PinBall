using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PinballController : MonoBehaviour
{
    [SerializeField] Lever _leftLever;
    [SerializeField] Lever _rightLever;
    [SerializeField] BallManager _ballManager;
    public InputMap _inputMap;

    private void Awake()
    {

        _inputMap = new InputMap();
        _inputMap.Gameplay.LeftLever.performed += _leftLever.LeverMove;
        _inputMap.Gameplay.LeftLever.canceled -= _leftLever.LeverMove;
        _inputMap.Gameplay.RigthLever.performed += _rightLever.LeverMove;
        _inputMap.Gameplay.RigthLever.canceled -= _rightLever.LeverMove;

    }
    private void FixedUpdate()
    {
        CheckBallDeath();
        if (_inputMap.Gameplay.BallForce.IsPressed() == true)
        {
            _ballManager._ballDeath = false;
        }
    }
    private void CheckBallDeath()
    {
        if (_ballManager._ballDeath == true)
        {
            _inputMap.Gameplay.BallForce.performed += _ballManager.BallStartForce;
        }
        else
        {
            _inputMap.Gameplay.BallForce.performed -= _ballManager.BallStartForce;
        }
    }

    private void OnEnable()
    {
        _inputMap.Enable();
    }

    private void OnDisable()
    {
        _inputMap.Disable();
    }
}
