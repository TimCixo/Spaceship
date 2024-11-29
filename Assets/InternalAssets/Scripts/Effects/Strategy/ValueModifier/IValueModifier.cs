using UnityEngine;

public interface IValueModifier
{
    public float Value { get; }
    public bool IsDynamic { get; set; }
    public AnimationCurve DynamicCurve { get; set; }

    public void Update();
}