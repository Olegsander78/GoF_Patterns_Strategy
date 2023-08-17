using UnityEngine;

public class Ball : MonoBehaviour
{
    public enum ColorType { Red, White, Green };

    public ColorType ColorBall { get; private set; }

    [field:SerializeField] public bool IsPopped { get; private set; }

    private Renderer _renderer;
    [SerializeField] private GameController _gameController;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        _gameController = FindObjectOfType<GameController>();
    }

    public void SetColor(ColorType color)
    {
        ColorBall = color;

        switch (color)
        {
            case ColorType.Red:
                _renderer.material.color = Color.red;
                break;
            case ColorType.White:
                _renderer.material.color = Color.white;
                break;
            case ColorType.Green:
                _renderer.material.color = Color.green;
                break;
        }
    }

    public void Pop()
    {
        if (!IsPopped)
        {
            IsPopped = true;
            this.gameObject.SetActive(false);
            _gameController.CheckWinCondition();
        }
    }

    private void OnMouseDown()
    {
        Pop();     
    }
}