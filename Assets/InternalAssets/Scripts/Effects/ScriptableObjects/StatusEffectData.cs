using Effects;
using Spaceship.Stats;
using UnityEngine;

namespace Spaceship.Effects
{
    [CreateAssetMenu(fileName = "StatusEffectData", menuName = "Effects/StatusEffectData")]
    public class StatusEffectData : SpaceshipEffectData
    {
        [SerializeField]
        private StatType _statType;
        [SerializeField]
        private float _value;
        [SerializeField]
        private bool _isPercentage;

        public StatType StatType => _statType;
        public float Value => _value;
        public bool IsPercentage => _isPercentage;

        private void OnEnable()
        {
            type = EffectType.Status;
        }
    }
}