using UnityEngine;

[RequireComponent(typeof(PlayerStatsView))]
public class PlayerStatsManager : MonoBehaviour
{
    [SerializeField]
    private SpaceshipBaseStats _spaceshipBaseStats;

    private PlayerStatsModel _model;
    private PlayerStatsView _view;
    private PlayerStatsPresenter _presenter;

    public PlayerStatsPresenter Presenter => _presenter;

    void Awake()
    {
        _model = new PlayerStatsModel(_spaceshipBaseStats);
        _view = GetComponent<PlayerStatsView>();
        _presenter = new PlayerStatsPresenter(_model, _view);
    }
}