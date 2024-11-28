using System;
using System.Collections.Generic;

public class EffectFabric
{
    private readonly Dictionary<EffectType, Func<SpaceshipEffectData, ISpaceshipEffect>> _effectRegistry;

    public EffectFabric(SpaceshipEffectsPresenter handler)
    {
        _effectRegistry = new Dictionary<EffectType, Func<SpaceshipEffectData, ISpaceshipEffect>>();

        RegisterEffect(EffectType.Status, data => new StatusEffect(data, handler));
        RegisterEffect(EffectType.Heal, data => new HealEffect(data, handler));
    }

    public void RegisterEffect(EffectType type, Func<SpaceshipEffectData, ISpaceshipEffect> constructor)
    {
        _effectRegistry[type] = constructor;
    }

    public ISpaceshipEffect ToSpaceshipEffect(SpaceshipEffectData effectData)
    {
        if (_effectRegistry.TryGetValue(effectData.Type, out var constructor))
        {
            return constructor(effectData);
        }

        throw new ArgumentException($"Effect type {effectData.Type} is not registered.");
    }
}