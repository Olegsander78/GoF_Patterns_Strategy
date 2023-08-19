using UnityEngine;

public class TradeDayController : MonoBehaviour
{
    public DaysOfWeek CurrentDayOfWeek { get => _currentDayOfWeek; }

    private DaysOfWeek _currentDayOfWeek;

    private void Awake()
    {
        InitTradeDay();
    }

    public void InitTradeDay()
    {       
        _currentDayOfWeek = (DaysOfWeek)Random.Range(0, 6);
        Debug.Log($"<color=magenta>Today is {_currentDayOfWeek}</color>");
    }
}