
public class PlayerStatsPresenter
{
    private PlayerStatsModel _model;
    private PlayerStatsView _view;

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