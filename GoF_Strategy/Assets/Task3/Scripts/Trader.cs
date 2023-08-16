using System.Collections.Generic;
using UnityEngine;

public class Trader : MonoBehaviour
{
    private Dictionary<Weekday, ITradeBehavior> _tradeBehaviors;
    private Weekday _currentWeekday;

    private void Start()
    {
        _tradeBehaviors = new Dictionary<Weekday, ITradeBehavior>()
        {
            { Weekday.Monday, new ArmorTrade() },
            { Weekday.Tuesday, new FruitTrade() },
            { Weekday.Wednesday, new ArmorTrade() },
            { Weekday.Thursday, new FruitTrade() },
            { Weekday.Friday, new FruitTrade() },
            { Weekday.Saturday, new NoTrade() },
            { Weekday.Sunday, new NoTrade() }
        };
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerCharacter playerCharacter))
            DoTrade();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out PlayerCharacter playerCharacter))
            Debug.Log($"<color=green>See you later!</color>");
    }
    private void DoTrade()
    {
        _currentWeekday = (Weekday)Random.Range(0, 7);
        ITradeBehavior currentBehavior = _tradeBehaviors[_currentWeekday];
        Debug.Log($"<color=magenta>Today is {_currentWeekday}</color>");
        currentBehavior.Trade();
    }

    public enum Weekday
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}