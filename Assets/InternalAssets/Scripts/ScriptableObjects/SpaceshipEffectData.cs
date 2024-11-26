using UnityEngine;

public abstract class SpaceshipEffectData : ScriptableObject
{
    [SerializeField] 
    private string _name;
    [SerializeField] 
    private EffectType _effectType;
    [SerializeField] 
    private EffectDurationType _durationType;
    [SerializeField] 
    private bool _isDynamic;
    [SerializeField] 
    private AnimationCurve _dynamicCurve;

    public string Name => _name;
    public EffectType EffectType => _effectType;
    public EffectDurationType DurationType => _durationType;
    public bool IsDynamic => _isDynamic;
    public AnimationCurve DynamicCurve => _dynamicCurve;
}