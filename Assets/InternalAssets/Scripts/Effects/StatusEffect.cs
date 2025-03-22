using Effects.LifetimeHandler;
using Effects.ValueModifier;
using Spaceship.Effects;

using Modifier = Spaceship.Stats.Modifier;
using StatType = Spaceship.Stats.StatType;

namespace Effects
{
    public class StatusEffect : ISpaceshipEffect
    {
        private StatusEffectData _data;
        private Presenter _handler;

        public IValueModifier ValueModifier { get; set; }
        public ILifetimeHandler LifetimeHandler { get; set; }

        public StatusEffect(SpaceshipEffectData effectData, Presenter handler)
        {
            _data = effectData as StatusEffectData;
            _handler = handler;
        }

        public void Update()
        {
            LifetimeHandler.Update();
            ValueModifier.Update();

            if (_data.IsPercentage)
            {
                _handler.Model.PercentageModifier += ToModifier();
            }
            else
            {
                _handler.Model.NumericModifier += ToModifier();
            }
        }

        public void Destroy()
        {
            _handler.RemoveEffect(this);
        }

        private Modifier ToModifier()
        {
            Modifier modifier = new Modifier();

            switch (_data.StatType)
            {
                case StatType.MovementSpeed:
                    modifier.MovementSpeed = _data.Value * ValueModifier.Value;
                    break;
                case StatType.RotationSpeed:
                    modifier.RotationSpeed = _data.Value * ValueModifier.Value;
                    break;
                case StatType.MaxHealth:
                    modifier.MaxHealth = _data.Value * ValueModifier.Value;
                    break;
                case StatType.AttackDamage:
                    modifier.AttackDamage = _data.Value * ValueModifier.Value;
                    break;
                case StatType.AttackSpeed:
                    modifier.AttackSpeed = _data.Value * ValueModifier.Value;
                    break;
            }

            return modifier;
        }
    }
}