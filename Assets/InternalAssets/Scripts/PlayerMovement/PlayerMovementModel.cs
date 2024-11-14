using UnityEngine;

public class PlayerMovementModel
{
    private float _movementSpeed;
    private float _rotationSpeed;
    private Vector2 _direction;

    public float MovementSpeed => _movementSpeed;
    public float RotationSpeed => _rotationSpeed;
    public Vector2 Direction
    {
        get => _direction;
        set => _direction = value;
    }

    public PlayerMovementModel(float movementSpeed, float rotationSpeed)
    {
        _movementSpeed = movementSpeed;
        _rotationSpeed = rotationSpeed;
    }
}
