using UnityEngine;

[RequireComponent(typeof(PlayerMovementView), typeof(SpaceshipStatsManager))]
public class PlayerMovementManager : MonoBehaviour, IBootstrapable
{ 
    private PlayerMovementModel _model;
    private PlayerMovementView _view;
    private PlayerMovementPresenter _presenter;

    public PlayerMovementPresenter Presenter => _presenter;

    public void BootstrapAwake()
    {
        _model = new PlayerMovementModel(GetComponent<SpaceshipStatsManager>().Presenter);
        _view = GetComponent<PlayerMovementView>();
        _presenter = new PlayerMovementPresenter(_model, _view);
    }
}