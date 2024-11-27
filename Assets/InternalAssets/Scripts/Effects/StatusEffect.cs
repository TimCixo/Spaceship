using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StatusEffect : ISpaceshipEffect
{
    private StatusEffectData _effectData;

    public StatusEffect(SpaceshipEffectData effectData)
    {
        _effectData = effectData as StatusEffectData;
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