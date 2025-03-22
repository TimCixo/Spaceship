using Spaceship.Effects;

namespace Spaceship.Sprint
{
    public class Model
    {
        private Effects.Presenter _effectsPresenter;
        private StatusEffectData _sprintEffect;

        public Effects.Presenter EffectsPresenter => _effectsPresenter;
        public StatusEffectData SprintEffect => _sprintEffect;

        public Model(Effects.Presenter effectsPresenter, StatusEffectData sprintEffect)
        {
            _effectsPresenter = effectsPresenter;
            _sprintEffect = sprintEffect;
        }
    }
}