using UnityEditor.EditorTools;
using UnityEngine;

public abstract class SpaceshipEffectData : ScriptableObject
{
    [SerializeField, Tooltip("Effect name")]
    private string _name;
    [SerializeField, Tooltip("Effect duration type")]
    private EffectDurationType _durationType;
    [SerializeField, Tooltip("Value changes over time")]
    private bool _isDynamic;
    [SerializeField, Tooltip("Animation curve to change the effect value over time")]
    private AnimationCurve _dynamicCurve;

    protected EffectType type;

    public string Name => _name;
    public EffectType Type => type;
    public EffectDurationType DurationType => _durationType;
    public bool IsDynamic => _isDynamic;
    public AnimationCurve DynamicCurve => _dynamicCurve;
}
