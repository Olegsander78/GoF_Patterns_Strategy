using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(
    fileName = "New trade day Config",
    menuName = "Trade days Config")]
public class TradeDaysConfig : ScriptableObject
{
    [SerializeField] private List<BehaviorDayPair> _behaviorDayPairs;

    public ITradeBehavior GetBehaviorByDay(DaysOfWeek dayOfWeek)
    {
        foreach (BehaviorDayPair behaviorDayPair in _behaviorDayPairs)
        {
            //if (behaviorDayPair.DayOfWeek == dayOfWeek)
            //{
            //    return behaviorDayPair.Behavior;
            //}
        }

        return null;
    }

    public List<BehaviorDayPair> GetBehaviors()
    {
        return _behaviorDayPairs;
    }
}