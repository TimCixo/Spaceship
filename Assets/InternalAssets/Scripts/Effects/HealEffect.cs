using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealEffect : ISpaceshipEffect
{
    private HealEffectData _effectData;
    private SpaceshipEffectsPresenter _handler;

    public HealEffect(SpaceshipEffectData effectData, SpaceshipEffectsPresenter handler)
    {
        _effectData = effectData as HealEffectData;
        _handler = handler;
    }

    public void Start()
    {
        if (_effectData.DurationType == EffectDurationType.Instant)
        {

        }
    }

    public void Update()
    {
        if (_effectData.DurationType == EffectDurationType.Instant)
        {
            return;
        }

        
    }

    public void Destroy()
    {
        _handler.RemoveEffect(this);
    }
}