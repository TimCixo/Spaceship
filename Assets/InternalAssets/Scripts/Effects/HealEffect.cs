using System;

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
        float value;

        LifetimeHandler.Update();
        ValueModifier.Update();

        if (_data.IsPercentage)
        {
            value = _handler.Model.StatsManager.Presenter.CurrentHealth * _data.Value / 100;
        }
        else
        {
            value = _data.Value;
        }
        
        _handler.Model.StatsManager.Presenter.TakeHeal(value);
    }

    public void Destroy()
    {
        _handler.RemoveEffect(this);
    }
}