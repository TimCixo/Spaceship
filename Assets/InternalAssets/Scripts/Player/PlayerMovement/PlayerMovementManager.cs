using UnityEngine;

[RequireComponent(typeof(PlayerMovementView), typeof(PlayerStatsManager))]
public class PlayerMovementManager : MonoBehaviour
{ 
    private PlayerMovementView _view;
    private PlayerMovementPresenter _presenter;
    private PlayerMovementModel _model;

    public PlayerMovementPresenter Presenter => _presenter;

    private void Awake()
    {
        _model = new PlayerMovementModel(GetComponent<PlayerStatsManager>().Presenter);
        _view = GetComponent<PlayerMovementView>();
        _presenter = new PlayerMovementPresenter(_model, _view);
    }
}
