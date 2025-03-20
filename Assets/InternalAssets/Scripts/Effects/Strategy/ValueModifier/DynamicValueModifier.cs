using Effects.LifetimeHandler;
using UnityEngine;

namespace Effects.ValueModifier
{
    public class DynamicValueModifier : IValueModifier
    {
        private float _value;

        public float Value => _value;
        public AnimationCurve DynamicCurve { get; set; }
        public ILifetimeHandler LifetimeHandler { get; set; }

        public void Update()
        {
            float percent = Mathf.Clamp((float)(LifetimeHandler.TimePassed.TotalMilliseconds / LifetimeHandler.Duration.TotalMilliseconds), 0f, 1f);

            _value = DynamicCurve.Evaluate(percent);
        }
    }
}