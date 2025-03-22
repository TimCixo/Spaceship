using Effects;

namespace Spaceship.Sprint
{
    public class Presenter
    {
        private Model _model;
        private View _view;

        public Presenter(Model model, View view)
        {
            _model = model;
            _view = view;

            _view.OnSprintPerformed += HandleSprintPerformed;
        }

        private void HandleSprintPerformed()
        {
            EffectFabric effectFabric = new EffectFabric();
            ISpaceshipEffect effect = effectFabric.GetSpaceshipEffect(_model.SprintEffect, _model.EffectsPresenter);

            // TODO: Інціцалізуються не втому порядку модулі, йопта. Зроби, щоб було правильно. Інакше пізда
            _model.EffectsPresenter.AddEffect(effect);

            _view.OnSprintCanceled += effect.Destroy;
        }
    }
}