public class SpaceshipStatsModel
{
    private SpaceshipBaseStats _spaceshipBaseStats;
    private float _movementSpeed;
    private float _rotationSpeed;
    private float _health;
    private float _attackDamage;
    private float _attackSpeed;

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
    public float AttackDamage
    {
        get { return _attackDamage; }
        set { _attackDamage = value > 0 ? value : 0; }
    }

    public float AttackSpeed
    {
        get { return _attackSpeed; }
        set { _attackSpeed = value > 0 ? value : 0; }
    }

    public SpaceshipStatsModel(SpaceshipBaseStats spaceshipBaseStats)
    {
        _spaceshipBaseStats = spaceshipBaseStats;

        Refresh();
    }

    public void Refresh() 
    { 
        _movementSpeed = _spaceshipBaseStats.MovementSpeed;
        _rotationSpeed = _spaceshipBaseStats.RotationSpeed;
        _health = _spaceshipBaseStats.MaxHealth;
        _attackDamage = _spaceshipBaseStats.AttackDamage;
        _attackSpeed = _spaceshipBaseStats.AttackSpeed;
    }
}