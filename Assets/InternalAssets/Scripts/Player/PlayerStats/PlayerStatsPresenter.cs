
public class PlayerStatsPresenter
{
    private PlayerStatsModel _model;
    private PlayerStatsView _view;

    public float MovementSpeed => _model.MovementSpeed;
    public float RotationSpeed => _model.RotationSpeed;
    public float Health => _model.Health;
    public float Damage => _model.Damage;

    public PlayerStatsPresenter(PlayerStatsModel model, PlayerStatsView view)
    {
        _model = model;
        _view = view;
    }

    public void Refresh()
    {
        _model.Refresh();
    }
}