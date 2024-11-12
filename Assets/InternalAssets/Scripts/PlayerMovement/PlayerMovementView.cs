using System;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovementView : MonoBehaviour
{
    [SerializeField]
    private InputActionReference _moveAction;
    private Rigidbody2D _rigidbody2D;

    public Rigidbody2D Rigidbody2D => _rigidbody2D;
    public Action<Vector2> OnMovePerformed;
    public Action OnMoveCanceled;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        _moveAction.action.Enable();
        _moveAction.action.performed += HandleMovePerformed;
        _moveAction.action.canceled += HandleMoveCanceled;
    }

    private void OnDisable()
    {
        _moveAction.action.Disable();
        _moveAction.action.performed -= HandleMovePerformed;
        _moveAction.action.canceled -= HandleMoveCanceled;
    }

    private void HandleMovePerformed(InputAction.CallbackContext context)
    {
        OnMovePerformed?.Invoke(context.ReadValue<Vector2>());
    }

    private void HandleMoveCanceled(InputAction.CallbackContext context)
    {
        OnMoveCanceled?.Invoke();
    }
}
