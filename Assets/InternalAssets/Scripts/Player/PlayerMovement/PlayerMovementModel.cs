using UnityEngine;

public class PlayerMovementModel
{
    private PlayerStatsPresenter _statsPresenter;
    private Vector2 _direction;

    public PlayerStatsPresenter StatsPresenter => _statsPresenter;
    public Vector2 Direction
    {
        get => _direction;
        set => _direction = value;
    }

    public PlayerMovementModel(PlayerStatsPresenter statsPresenter)
    {
        _statsPresenter = statsPresenter;
    }
}
