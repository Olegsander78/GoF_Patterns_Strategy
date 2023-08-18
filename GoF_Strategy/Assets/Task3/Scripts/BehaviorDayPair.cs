using System;
using UnityEngine;

[Serializable]
public class BehaviorDayPair
{
    public DaysOfWeek DayOfWeek;

    [SerializeReference] ITradeBehavior Behavior;
}