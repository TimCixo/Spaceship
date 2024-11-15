public class SpaceshipStatsModel
{
    private SpaceshipBaseStats _spaceshipBaseStats;
    private float _movementSpeed;
    private float _rotationSpeed;
    private float _health;
    private float _damage;

    public float MovementSpeed
    {
        get { return _movementSpeed; }
        set { _movementSpeed = value > 0 ? value : 0; }
    }
    public float RotationSpeed
    {
        get { return _rotationSpeed; }
        set { _rotationSpeed = value > 0 ? value : 0; }
    }
    public float Health
    {
        get { return _health; }
        set { _health = value > 0 ? value : 0; }
    }
    public float Damage
    {
        get { return _damage; }
        set { _damage = value > 0 ? value : 0; }
    }

    public SpaceshipStatsModel(SpaceshipBaseStats spaceshipBaseStats)
    {
        _spaceshipBaseStats = spaceshipBaseStats;

        Refresh();
    }

    public void Refresh() 
    { 
        _movementSpeed = _spaceshipBaseStats.BaseMovementSpeed;
        _rotationSpeed = _spaceshipBaseStats.BaseRotationSpeed;
        _health = _spaceshipBaseStats.MaxHealth;
        _damage = _spaceshipBaseStats.BaseDamage;
    }
}