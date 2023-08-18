using UnityEngine;

public class Trader : MonoBehaviour
{
    [SerializeField] private TradeHandler _tradeHandler;

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
        //var currentDayOfWeek = _tradeHandler.GetBehaviorByDay();
        //ITradeBehavior currentBehavior =  _tradeHandler.TradeBehaviors[currentDayOfWeek];
        //currentBehavior.Trade();
    }    
}