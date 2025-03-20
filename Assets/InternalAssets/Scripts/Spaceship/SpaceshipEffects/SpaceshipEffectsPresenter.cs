using Effects;
using Spaceship.Stats;

namespace Spaceship.Effects
{
    public class SpaceshipEffectsPresenter
    {
        private SpaceshipEffectsModel _model;
        private SpaceshipEffectsView _view;

        public SpaceshipEffectsModel Model => _model;

        public SpaceshipEffectsPresenter(SpaceshipEffectsModel model, SpaceshipEffectsView view)
        {
            _model = model;
            _view = view;

            _view.OnUpdate += Update;
        }

        private void Update()
        {
            _model.NumericModifier = new Modifier();
            _model.PercentageModifier = new Modifier();

            foreach (ISpaceshipEffect effect in _model.Effects)
            {
                effect.Update();
            }

            _model.Modifier = ModifierSum();

            _model.StatsManager.Presenter.SetValues(_model.Modifier);
        }

        private Modifier ModifierSum()
        {
            Modifier baseModifier = _model.StatsManager.Presenter.BaseStatsToModifier();

            return ((baseModifier + _model.NumericModifier) * _model.PercentageModifier / 100) + _model.NumericModifier;
        }

        public void AddEffect(ISpaceshipEffect effect)
        {
            _model.Effects.Add(effect);

            effect.Update();
        }

        public void RemoveEffect(ISpaceshipEffect effect)
        {
            _model.Effects.Remove(effect);
        }
    }
}