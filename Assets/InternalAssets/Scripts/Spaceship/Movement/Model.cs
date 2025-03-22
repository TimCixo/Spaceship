using Spaceship.Stats;
using UnityEngine;

namespace Spaceship.Movement
{
    public class Model
    {
        private Stats.Presenter _statsPresenter;
        private Vector2 _direction;

        public Stats.Presenter StatsPresenter => _statsPresenter;
        public Vector2 Direction
        {
            get => _direction;
            set => _direction = value;
        }

        public Model(Stats.Presenter statsPresenter)
        {
            _statsPresenter = statsPresenter;
        }
    }
}