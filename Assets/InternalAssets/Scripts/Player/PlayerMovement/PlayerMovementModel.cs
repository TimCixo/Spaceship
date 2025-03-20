using Spaceship.Stats;
using UnityEngine;

namespace Spaceship.Movement
{
    public class PlayerMovementModel
    {
        private SpaceshipStatsPresenter _statsPresenter;
        private Vector2 _direction;

        public SpaceshipStatsPresenter StatsPresenter => _statsPresenter;
        public Vector2 Direction
        {
            get => _direction;
            set => _direction = value;
        }

        public PlayerMovementModel(SpaceshipStatsPresenter statsPresenter)
        {
            _statsPresenter = statsPresenter;
        }
    }
}