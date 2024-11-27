using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealEffect : ISpaceshipEffect
{
    private HealEffectData _effectData;

    public HealEffect(SpaceshipEffectData effectData)
    {
        _effectData = effectData as HealEffectData;
    }

    public void Start()
    {
    }

    public void Update()
    {
    }

    public void Destroy()
    {
    }
}