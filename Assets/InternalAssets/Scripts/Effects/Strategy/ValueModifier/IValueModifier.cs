using UnityEngine;

public interface IValueModifier
{
    public float Value { get; }
    public AnimationCurve DynamicCurve { get; set; }
    public ILifetimeHandler LifetimeHandler { get; set; }

    public void Update();
}