using System;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Action OnEndedGame;
    public Action<string> OnSelectedCondition;
    public ColorType ColorToPop { get => _colorToPop;}

    [SerializeField] private BallSpawner _ballSpawner;
    [SerializeField] private ColorType _colorToPop;

    private bool _popAllButtonClicked = false;
    private bool _popOneColorButtonClicked = false;

    private IWinCondition _winConditionStrategy;  

    public void SelectPopAllStrategy()
    {
        _winConditionStrategy = new PopAll();

        OnSelectedCondition?.Invoke($"Pop all the balloons to win!");

        _popAllButtonClicked = true;
        CheckButtonState();
    }

    public void SelectPopOneColorStrategy()
    {
        _winConditionStrategy = new PopOneColor(_colorToPop);

        OnSelectedCondition?.Invoke($"To win, pop all the balls of color - {_colorToPop}");

        _popOneColorButtonClicked = true;
        CheckButtonState();
    }

    public void CheckWinCondition()
    {
        if (_winConditionStrategy.HasWon(_ballSpawner.Balls))
            OnEndedGame?.Invoke();
    }    

    private void CheckButtonState()
    {
        if (_popAllButtonClicked || _popOneColorButtonClicked)
        {
            _ballSpawner.SpawnBalls();

            foreach (var ball in _ballSpawner.Balls)
            {
                ball.OnPuped += CheckWinCondition;
            }
        }
    }    

    private void OnDisable()
    {
        foreach (var ball in _ballSpawner.Balls)
        {
            ball.OnPuped -= CheckWinCondition;
        }
    }
}