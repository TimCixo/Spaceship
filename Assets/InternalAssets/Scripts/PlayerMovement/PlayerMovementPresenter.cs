using UnityEngine;

public class PlayerMovementPresenter
{
    private PlayerMovementModel _model;
    private PlayerMovementView _view;

    public PlayerMovementPresenter(PlayerMovementModel model, PlayerMovementView view)
    {
        _model = model;
        _view = view;

        _view.OnMovePerformed += OnMovePerformed;
        _view.OnMoveCanceled += OnMoveCanceled;
    }

    private void OnMovePerformed(Vector2 direction)
    {
        _view.Rigidbody2D.velocity = direction * _model.MovementSpeed;
    }

    public void OnMoveCanceled() 
    { 
        _view.Rigidbody2D.velocity = Vector2.zero;
    }
}
