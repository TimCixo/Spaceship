using UnityEngine;

[RequireComponent(typeof(PlayerMovementView), typeof(SpaceshipStatsManager))]
public class PlayerMovementManager : MonoBehaviour
{ 
    private PlayerMovementView _view;
    private PlayerMovementPresenter _presenter;
    private PlayerMovementModel _model;

    public PlayerMovementPresenter Presenter => _presenter;

    private void Awake()
    {
        _model = new PlayerMovementModel(GetComponent<SpaceshipStatsManager>().Presenter);
        _view = GetComponent<PlayerMovementView>();
        _presenter = new PlayerMovementPresenter(_model, _view);
    }
}