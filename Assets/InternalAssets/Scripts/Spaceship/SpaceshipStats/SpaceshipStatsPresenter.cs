
public class SpaceshipStatsPresenter
{
    private SpaceshipStatsModel _model;
    private SpaceshipStatsView _view;

    public float MovementSpeed => _model.MovementSpeed;
    public float RotationSpeed => _model.RotationSpeed;
    public float MaxHealth => _model.MaxHealth;
    public float CurrentHealth => _model.CurrentHealth;
    public float AttackDamage => _model.AttackDamage;
    public float AttackSpeed => _model.AttackSpeed;

    public SpaceshipStatsPresenter(SpaceshipStatsModel model, SpaceshipStatsView view)
    {
        _model = model;
        _view = view;
    }

    public void TakeHeal(float value)
    {
        _model.CurrentHealth += value;
    }

    public Modifier BaseStatsToModifier()
    {
        return new Modifier
        {
            MovementSpeed = _model.BaseStats.MovementSpeed,
            RotationSpeed = _model.BaseStats.RotationSpeed,
            MaxHealth = _model.BaseStats.MaxHealth,
            AttackDamage = _model.BaseStats.AttackDamage,
            AttackSpeed = _model.BaseStats.AttackSpeed
        };
    }

    public void SetValues(Modifier modifier)
    {
        _model.ResetValues();

        _model.MovementSpeed += modifier.MovementSpeed;
        _model.RotationSpeed += modifier.RotationSpeed;
        _model.MaxHealth += modifier.MaxHealth;
        _model.AttackDamage += modifier.AttackDamage;
        _model.AttackSpeed += modifier.AttackSpeed;
    }
}