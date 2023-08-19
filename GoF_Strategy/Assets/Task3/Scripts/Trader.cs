using UnityEngine;

public class Trader : MonoBehaviour
{
    [SerializeField] private TradeDayController _tradeDayController;
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
        ITradeBehavior currentBehavior = _tradeHandler.GetTradeBehavior(_tradeDayController.CurrentDayOfWeek);
        currentBehavior.Trade();
    }    
}