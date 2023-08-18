using System.Collections.Generic;
using UnityEngine;

public class TradeHandler : MonoBehaviour
{
    [SerializeField] private TradeDaysConfig _config;

    public ITradeBehavior GetBehaviorByDay(DaysOfWeek dayOfWeek)
    {
        return _config.GetBehaviorByDay(dayOfWeek);
    }

    public List<BehaviorDayPair> GetBehaviors()
    {
        return _config.GetBehaviors();
    }

    //internal Dictionary<DaysOfWeek, ITradeBehavior> TradeBehaviors { get => _tradeBehaviors;}

    //private Dictionary<DaysOfWeek, ITradeBehavior> _tradeBehaviors = new ()
    //    {
    //        { DaysOfWeek.Monday, new ArmorTrade() },
    //        { DaysOfWeek.Tuesday, new FruitTrade() },
    //        { DaysOfWeek.Wednesday, new ArmorTrade() },
    //        { DaysOfWeek.Thursday, new FruitTrade() },
    //        { DaysOfWeek.Friday, new FruitTrade() },
    //        { DaysOfWeek.Saturday, new NoTrade() },
    //        { DaysOfWeek.Sunday, new NoTrade() }
    //    };

    //private DaysOfWeek _currentDayOfWeek;


    //public void InitTradeDay()
    //{
    //    _currentDayOfWeek = (DaysOfWeek)Random.Range(0, 7);

    //    Debug.Log($"<color=magenta>Today is {_currentDayOfWeek}</color>");
    //}

    //public DaysOfWeek GetCurrentDay()
    //{
    //    return _currentDayOfWeek;
    //}
}

