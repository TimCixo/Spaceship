using System;
using System.Collections.Generic;

public class EffectFabric
{
    private readonly Dictionary<EffectType, Func<SpaceshipEffectData, SpaceshipEffectsPresenter, ISpaceshipEffect>> _effectRegistry;

    public EffectFabric()
    {
        _effectRegistry = new Dictionary<EffectType, Func<SpaceshipEffectData, SpaceshipEffectsPresenter, ISpaceshipEffect>>();

        RegisterEffect(EffectType.Status, (effectData, handler) => new StatusEffect(effectData, handler));
        RegisterEffect(EffectType.Heal, (effectData, handler) => new HealEffect(effectData, handler));
    }

    public void RegisterEffect(EffectType type, Func<SpaceshipEffectData, SpaceshipEffectsPresenter, ISpaceshipEffect> constructor)
    {
        _effectRegistry[type] = constructor;
    }

    public ISpaceshipEffect ToSpaceshipEffect(SpaceshipEffectData effectData, SpaceshipEffectsPresenter handler)
    {
        if (_effectRegistry.TryGetValue(effectData.Type, out var constructor))
        {
            ISpaceshipEffect effect = constructor(effectData, handler);

            effect.Modifier = GetValueModifier(effectData.IsDynamic);
            effect.LifetimeHandler = GetLifetimeHandler(effectData.DurationType, effectData.Duration);

            return effect;
        }

        throw new ArgumentException($"Effect type {effectData.Type} is not registered.");
    }

    private IValueModifier GetValueModifier(bool IsDynamic)
    {
        if (IsDynamic)
        {
            return new DynamicValueModifier();
        }
        else
        {
            return new StaticValueModifier();
        }
    }

    private ILifetimeHandler GetLifetimeHandler(EffectDurationType durationType, TimeSpan duration)
    {
        switch (durationType)
        {
            case EffectDurationType.Instant:
                return new InstantLifetimeHandler();
            case EffectDurationType.Timed:
                return new TimedLifetimeHandler(duration);
            case EffectDurationType.Permanent:
                return new PermanentLifetimeHandler();
            default:
                throw new ArgumentException($"Effect duration type {durationType} is not supported.");
        }
    }
}