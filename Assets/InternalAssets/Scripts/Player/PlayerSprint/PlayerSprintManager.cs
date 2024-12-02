using UnityEngine;

[RequireComponent(typeof(PlayerSprintView), typeof(SpaceshipEffectsManager))]
public class PlayerSprintManager : MonoBehaviour
{
    private PlayerSprintModel _model;
    private PlayerSprintView _view;
    private PlayerSprintPresenter _presenter;
    [SerializeField]
    private StatusEffectData _sprintEffect;

    public PlayerSprintPresenter Presenter => _presenter;

    void Awake()
    {
        _model = new PlayerSprintModel(GetComponent<SpaceshipEffectsManager>().Presenter, _sprintEffect);
        _view = GetComponent<PlayerSprintView>();
        _presenter = new PlayerSprintPresenter(_model, _view);
    }
}