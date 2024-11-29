    using System.Collections;
    using System.Collections.Generic;
    using Unity.VisualScripting;
    using UnityEngine;

    // TODO: Refactor this piece of shit
    public class StatusEffect : ISpaceshipEffect
    {
        private StatusEffectData _data;
        private SpaceshipEffectsPresenter _handler;
        private Modifier _modifier;
        private float _start;
        private float _current;

        public IValueModifier Modifier { get; set; }
        public ILifetimeHandler LifetimeHandler{ get; set; }

        public StatusEffect(SpaceshipEffectData effectData, SpaceshipEffectsPresenter handler)
        {
            _data = effectData as StatusEffectData;
            _handler = handler;
            _modifier = ToModifier();
            _start = Time.time;
            _current = 0f;
        }

        public void Start()
        {
            if (_data.DurationType == EffectDurationType.Instant || !_data.IsDynamic)
            {
                _handler.Model.Modifier += _modifier;
            }
        }

        public void Update()
        {
            if (_data.DurationType == EffectDurationType.Instant)
            {
                return;
            }

            // Розрахунок, скільки часу пройшло з початку ефекту
            // Якщо час закінчився і EffectDurationType.Timed, то видалити ефект
            // Якщо _data.IsDynamic : bool, то на основі _data.DynamicCurve : AnimationCurve і _current : float розрахувати, наскільки збільшити ефект _data.Value
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
                case SpaceshipStatType.MovementSpeed:
                    modifier.MovementSpeed = _data.Value;
                    break;
                case SpaceshipStatType.RotationSpeed:
                    modifier.RotationSpeed = _data.Value;
                    break;
                case SpaceshipStatType.MaxHealth:
                    modifier.MaxHealth = _data.Value;
                    break;
                case SpaceshipStatType.AttackDamage:
                    modifier.AttackDamage = _data.Value;
                    break;
                case SpaceshipStatType.AttackSpeed:
                    modifier.AttackSpeed = _data.Value;
                    break;
            }

            return modifier;
        }
    }