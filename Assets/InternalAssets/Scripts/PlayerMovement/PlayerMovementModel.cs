public class PlayerMovementModel
{
    private float _movementSpeed;

    public float MovementSpeed => _movementSpeed;

    public PlayerMovementModel(float movementSpeed)
    {
        _movementSpeed = movementSpeed;
    }
}
