using UnityEngine;

public class TradeDayController : MonoBehaviour
{
    //private TradeController _tradeController;
    private DaysOfWeek _currentDayOfWeek;

    private void Start()
    {
        //_tradeController = GetComponent<TradeController>();
        InitTradeDay();
    }

    public void InitTradeDay()
    {
        _currentDayOfWeek = (DaysOfWeek)Random.Range(0, 7);

        Debug.Log($"<color=magenta>Today is {_currentDayOfWeek}</color>");
    }

    public DaysOfWeek GetCurrentDay()
    {
        return _currentDayOfWeek;
    }
}