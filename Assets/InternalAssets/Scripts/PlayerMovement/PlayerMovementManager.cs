using UnityEngine;

[RequireComponent(typeof(PlayerMovementView))]
public class PlayerMovementManager : MonoBehaviour
{ 
    [SerializeField]
    private float _movementSpeed = 10;
    [SerializeField]
    private float _rotationSpeed = 10;

    private PlayerMovementView _view;
    private PlayerMovementPresenter _presenter;
    private PlayerMovementModel _model;

    public PlayerMovementPresenter Presenter => _presenter;

    private void Awake()
    {
        _model = new PlayerMovementModel(_movementSpeed, _rotationSpeed);
        _view = GetComponent<PlayerMovementView>();
        _presenter = new PlayerMovementPresenter(_model, _view);
    }
}
