using System;
using Unity.VisualScripting;
using UnityEngine;

public class SpaceshipEffectsPresenter
{
    private SpaceshipEffectsModel _model;
    private SpaceshipEffectsView _view;

    public SpaceshipEffectsModel Model => _model;

    public SpaceshipEffectsPresenter(SpaceshipEffectsModel model, SpaceshipEffectsView view)
    {
        _model = model;
        _view = view;

        _view.OnUpdate += Update;
    }

    private void Update()
    {
        foreach (ISpaceshipEffect effect in _model.Effects)
        {
            effect.Update();
        }
    }

    public void AddEffect(ISpaceshipEffect effect)
    {
        _model.Effects.Add(effect);

        effect.Start();
    }

    public void RemoveEffect(ISpaceshipEffect effect)
    {
        _model.Effects.Remove(effect);
    }
}