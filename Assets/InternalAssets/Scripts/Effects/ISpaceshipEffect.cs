using Effects.LifetimeHandler;
using Effects.ValueModifier;

namespace Effects
{
    public interface ISpaceshipEffect
    {
        public IValueModifier ValueModifier { get; set; }
        public ILifetimeHandler LifetimeHandler { get; set; }

        public void Update();
        public void Destroy();
    }
}