using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Ball.ColorType ColorToPop { get => _colorToPop;}

    [SerializeField] private BallSpawner _ballSpawner;
    [SerializeField] private GameObject _popAllButton;
    [SerializeField] private GameObject _popOneColorButton;
    [SerializeField] private Ball.ColorType _colorToPop;
    [SerializeField] private TextMeshProUGUI _conditionWinText;
    [SerializeField] private TextMeshProUGUI _winText;

    private bool _popAllButtonClicked = false;
    private bool _popOneColorButtonClicked = false;

    private IWinCondition _winConditionStrategy;    

    private void Start()
    {
        Init();
    }

    public void SelectPopAllStrategy()
    {
        _winConditionStrategy = new PopAll();

        DisableButtons();
        _conditionWinText.text = $"Что бы выиграть хлопни все шарики!";
        _popAllButtonClicked = true;
        CheckButtonState();
    }

    public void SelectPopOneColorStrategy()
    {
        _winConditionStrategy = new PopOneColor(_colorToPop);

        DisableButtons();        
        _conditionWinText.text = $"Что бы выиграть хлопни все шарики цвета - {_colorToPop}!";
        _popOneColorButtonClicked = true;
        CheckButtonState();
    }

    public void CheckWinCondition()
    {
        if (_winConditionStrategy.HasWon(_ballSpawner.Balls))
        {
            _winText.gameObject.SetActive(true);
            //Debug.Log("You win!");
        }
    }

    private void Init()
    {
        _popOneColorButton.GetComponentInChildren<TextMeshProUGUI>().text = $"Хлопнуть все шарики цвета - {_colorToPop}";
        _conditionWinText.gameObject.SetActive(false);
        _winText.gameObject.SetActive(false);
    }

    private void CheckButtonState()
    {
        if (_popAllButtonClicked || _popOneColorButtonClicked)
        {
            _ballSpawner.SpawnBalls();
        }
    }

    private void DisableButtons()
    {
        _popAllButton.SetActive(false);
        _popOneColorButton.SetActive(false);
        _conditionWinText.gameObject.SetActive(true);
    }
}