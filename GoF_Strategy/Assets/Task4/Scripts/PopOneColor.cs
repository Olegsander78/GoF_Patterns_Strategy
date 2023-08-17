using System.Collections.Generic;

public class PopOneColor : IWinCondition
{
    private Ball.ColorType _colorToPop;

    public PopOneColor(Ball.ColorType colorToPop)
    {
        _colorToPop = colorToPop;
    }

    public bool HasWon(List<Ball> balls)
    {
        return balls.TrueForAll(ball => ball.IsPopped || ball.ColorBall != _colorToPop);
    }
}