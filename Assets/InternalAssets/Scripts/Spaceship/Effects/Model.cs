using System.Collections.Generic;
using Effects;
using Spaceship.Stats;

namespace Spaceship.Effects
{
    public class Model
    {
        private List<ISpaceshipEffect> _effects = new List<ISpaceshipEffect>();
        private Stats.Manager _statsManager;

        public List<ISpaceshipEffect> Effects => _effects;
        public Modifier NumericModifier = new Modifier();
        public Modifier PercentageModifier = new Modifier();
        public Modifier Modifier = new Modifier();
        public Stats.Manager StatsManager => _statsManager;

        public Model(Stats.Manager statsManager)
        {
            _statsManager = statsManager;
        }
    }
}