using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TradeDayController))]
public class TradeDayControllerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Init Day of Week"))
        {
            TradeDayController tradeDayController = (TradeDayController)target;
            tradeDayController.InitTradeDay();
        }
    }
}