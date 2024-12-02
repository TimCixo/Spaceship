public class HealEffect : ISpaceshipEffect
{
    private HealEffectData _data;
    private SpaceshipEffectsPresenter _handler;

    public IValueModifier ValueModifier { get; set; }
    public ILifetimeHandler LifetimeHandler{ get; set; }

    public HealEffect(SpaceshipEffectData effectData, SpaceshipEffectsPresenter handler)
    {
        _data = effectData as HealEffectData;
        _handler = handler;
    }

    public void Update()
    {
        LifetimeHandler.Update();
        ValueModifier.Update();

        // TODO: Heal player
    }

    public void Destroy()
    {
        _handler.RemoveEffect(this);
    }
}