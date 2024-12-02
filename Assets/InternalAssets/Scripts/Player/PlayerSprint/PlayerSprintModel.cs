public class PlayerSprintModel
{
    private SpaceshipEffectsPresenter _effectsPresenter;
    private StatusEffectData _sprintEffect;

    public SpaceshipEffectsPresenter EffectsPresenter => _effectsPresenter;
    public StatusEffectData SprintEffect => _sprintEffect;

    public PlayerSprintModel(SpaceshipEffectsPresenter effectsPresenter, StatusEffectData sprintEffect)
    {
        _effectsPresenter = effectsPresenter;
        _sprintEffect = sprintEffect;
    }
}