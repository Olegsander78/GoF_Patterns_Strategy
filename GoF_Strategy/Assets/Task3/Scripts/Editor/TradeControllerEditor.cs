using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TradeController))]
public class TradeControllerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Init Day of Week"))
        {
            TradeController tradeController = (TradeController)target;
            tradeController.InitTradeDay();
        }
    }
}