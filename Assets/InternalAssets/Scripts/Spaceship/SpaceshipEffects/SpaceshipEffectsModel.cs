using System;
using System.Collections.Generic;

public class SpaceshipEffectsModel
{
    private List<ISpaceshipEffect> _effects = new List<ISpaceshipEffect>();
    private Modifier _modifier = new Modifier();

    public List<ISpaceshipEffect> Effects => _effects;
    public Modifier Modifier
    {
        get => _modifier;
        set
        {
            _modifier = value;

            OnModifierChanged?.Invoke(_modifier);
        }
    }

    public event Action<Modifier> OnModifierChanged;
}