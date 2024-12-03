using UnityEngine;

[RequireComponent(typeof(SpaceshipStatsView))]
public class SpaceshipStatsManager : MonoBehaviour, IBootstrapable
{
    [SerializeField]
    private SpaceshipBaseStats _spaceshipBaseStats;

    private SpaceshipStatsModel _model;
    private SpaceshipStatsView _view;
    private SpaceshipStatsPresenter _presenter;

    public SpaceshipStatsPresenter Presenter => _presenter;

    public void BootstrapAwake()
    {
        _model = new SpaceshipStatsModel(_spaceshipBaseStats);
        _view = GetComponent<SpaceshipStatsView>();
        _presenter = new SpaceshipStatsPresenter(_model, _view);
    }
}