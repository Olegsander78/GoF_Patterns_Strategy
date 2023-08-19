using System.Collections.Generic;
using UnityEngine;

public class TradeHandler : MonoBehaviour
{
    private Dictionary<DaysOfWeek, ITradeBehavior> _tradeBehaviors = new()
        {
            { DaysOfWeek.Monday, new ArmorTrade() },
            { DaysOfWeek.Tuesday, new FruitTrade() },
            { DaysOfWeek.Wednesday, new ArmorTrade() },
            { DaysOfWeek.Thursday, new FruitTrade() },
            { DaysOfWeek.Friday, new FruitTrade() },
            { DaysOfWeek.Saturday, new NoTrade() },
            { DaysOfWeek.Sunday, new NoTrade() }
        };   
    
    public ITradeBehavior GetTradeBehavior(DaysOfWeek daysOfWeek)
    {
        return _tradeBehaviors[daysOfWeek];
    }
}

