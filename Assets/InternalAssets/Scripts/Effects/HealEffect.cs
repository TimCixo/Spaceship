using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealEffect : ISpaceshipEffect
{
    private HealEffectData _effectData;
    private SpaceshipEffectsPresenter _handler;

    public IValueModifier Modifier { get; set; }
    public ILifetimeHandler LifetimeHandler{ get; set; }
    
    // TODO: subscitbe Update to OnUpdate event

    public HealEffect(SpaceshipEffectData effectData, SpaceshipEffectsPresenter handler)
    {
        _effectData = effectData as HealEffectData;
        _handler = handler;
    }

    public void Update()
    {
        // ! Do the shiiiiiiit
    }

    public void Destroy()
    {
        _handler.RemoveEffect(this);
    }
}