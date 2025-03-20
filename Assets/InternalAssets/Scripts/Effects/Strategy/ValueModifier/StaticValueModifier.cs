using Effects.LifetimeHandler;
using UnityEngine;

namespace Effects.ValueModifier
{
    public class StaticValueModifier : IValueModifier
    {
        public float Value => 1f;
        public AnimationCurve DynamicCurve { get; set; }
        public ILifetimeHandler LifetimeHandler { get; set; }

        public void Update()
        {
            // Do nothing
        }
    }
}