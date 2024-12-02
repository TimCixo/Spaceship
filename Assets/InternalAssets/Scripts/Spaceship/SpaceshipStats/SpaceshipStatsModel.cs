public class SpaceshipStatsModel
{
    private SpaceshipBaseStats _baseStats;
    private float _movementSpeed;
    private float _rotationSpeed;
    private float _maxHealth;
    private float _health;
    private float _attackDamage;
    private float _attackSpeed;


    public SpaceshipBaseStats BaseStats => _baseStats;
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
    public float MaxHealth
    {
        get { return _health; }
        set { _maxHealth = value > 0 ? value : 0; }
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
        _baseStats = spaceshipBaseStats;

        ResetValues();
    }

    public void ResetValues() 
    {
        _movementSpeed = _baseStats.MovementSpeed;
        _rotationSpeed = _baseStats.RotationSpeed;
        _maxHealth = _baseStats.MaxHealth;
        _health = _baseStats.MaxHealth;
        _attackDamage = _baseStats.AttackDamage;
        _attackSpeed = _baseStats.AttackSpeed;
    }
}