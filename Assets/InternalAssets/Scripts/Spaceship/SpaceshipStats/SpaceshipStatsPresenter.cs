
public class SpaceshipStatsPresenter
{
    private SpaceshipStatsModel _model;
    private SpaceshipStatsView _view;

    public float MovementSpeed => _model.MovementSpeed;
    public float RotationSpeed => _model.RotationSpeed;
    public float Health => _model.Health;
    public float AttackDamage => _model.AttackDamage;
    public float AttackSpeed => _model.AttackSpeed;

    public SpaceshipStatsPresenter(SpaceshipStatsModel model, SpaceshipStatsView view)
    {
        _model = model;
        _view = view;
    }

    public void Refresh()
    {
        _model.Refresh();
    }
}