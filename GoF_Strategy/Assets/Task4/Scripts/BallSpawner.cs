using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _ballPrefab;
    [SerializeField] private int _redBallsCount;
    [SerializeField] private int _whiteBallsCount;
    [SerializeField] private int _greenBallsCount;
    [SerializeField] private Transform _parent;
        
    public List<Ball> Balls { get { return _balls; } }

    private List<Ball> _balls = new List<Ball>();

    public void SpawnBalls()
    {
        for (int i = 0; i < _redBallsCount; i++)
        {
            SpawnBall(Ball.ColorType.Red);
        }
        for (int i = 0; i < _whiteBallsCount; i++)
        {
            SpawnBall(Ball.ColorType.White);
        }
        for (int i = 0; i < _greenBallsCount; i++)
        {
            SpawnBall(Ball.ColorType.Green);
        }
    }

    private void SpawnBall(Ball.ColorType color)
    {
        Vector3 position = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0f);
        GameObject ballObject = Instantiate(_ballPrefab, position, Quaternion.identity, _parent);
        Ball ball = ballObject.GetComponent<Ball>();
        ball.SetColor(color);
        _balls.Add(ball);
    }

    public void PopAllBalls()
    {
        foreach (Ball ball in _balls)
        {
            ball.Pop();
        }
    }

    public void PopColorBalls(Ball.ColorType color)
    {
        foreach (Ball ball in _balls)
        {
            if (ball.ColorBall == color)
            {
                ball.Pop();
            }
        }
    }
}