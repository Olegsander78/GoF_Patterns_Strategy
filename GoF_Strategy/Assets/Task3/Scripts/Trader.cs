using UnityEngine;

public class Trader : MonoBehaviour
{
    [SerializeField] private TradeController _tradeController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerCharacter playerCharacter))
        {
            //_tradeController.InitTradeDay();

            DoTrade();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out PlayerCharacter playerCharacter))
            Debug.Log($"<color=green>See you later!</color>");
    }

    private void DoTrade()
    {
        var currentDayOfWeek = _tradeController.GetCurrentDay();
        ITradeBehavior currentBehavior =  _tradeController.TradeBehaviors[currentDayOfWeek];
        //Debug.Log($"<color=magenta>Today is {currentDayOfWeek}</color>");
        currentBehavior.Trade();
    }    
}