public class StatusEffect : ISpaceshipEffect
{
    private StatusEffectData _data;
    private SpaceshipEffectsPresenter _handler;

    public IValueModifier ValueModifier { get; set; }
    public ILifetimeHandler LifetimeHandler { get; set; }

    public StatusEffect(SpaceshipEffectData effectData, SpaceshipEffectsPresenter handler)
    {
        _data = effectData as StatusEffectData;
        _handler = handler;
    }

    public void Update()
    {
        LifetimeHandler.Update();
        ValueModifier.Update();

        if (_data.IsPercentage)
        {
            _handler.Model.PercentageModifier += ToModifier();
        }
        else
        {
            _handler.Model.NumericModifier += ToModifier();
        }
    }

    public void Destroy()
    {
        _handler.RemoveEffect(this);
    }

    private Modifier ToModifier()
    {
        Modifier modifier = new Modifier();

        switch (_data.StatType)
        {
            case SpaceshipStatType.MovementSpeed:
                modifier.MovementSpeed = _data.Value * ValueModifier.Value;
                break;
            case SpaceshipStatType.RotationSpeed:
                modifier.RotationSpeed = _data.Value * ValueModifier.Value;
                break;
            case SpaceshipStatType.MaxHealth:
                modifier.MaxHealth = _data.Value * ValueModifier.Value;
                break;
            case SpaceshipStatType.AttackDamage:
                modifier.AttackDamage = _data.Value * ValueModifier.Value;
                break;
            case SpaceshipStatType.AttackSpeed:
                modifier.AttackSpeed = _data.Value * ValueModifier.Value;
                break;
        }

        return modifier;
    }
}
