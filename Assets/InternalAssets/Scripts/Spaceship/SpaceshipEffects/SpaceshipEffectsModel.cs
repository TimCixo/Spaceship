using System.Collections.Generic;
using Effects;
using Spaceship.Stats;

namespace Spaceship.Effects
{
    public class SpaceshipEffectsModel
    {
        private List<ISpaceshipEffect> _effects = new List<ISpaceshipEffect>();
        private SpaceshipStatsManager _statsManager;

        public List<ISpaceshipEffect> Effects => _effects;
        public Modifier NumericModifier = new Modifier();
        public Modifier PercentageModifier = new Modifier();
        public Modifier Modifier = new Modifier();
        public SpaceshipStatsManager StatsManager => _statsManager;

        public SpaceshipEffectsModel(SpaceshipStatsManager statsManager)
        {
            _statsManager = statsManager;
        }
    }
}