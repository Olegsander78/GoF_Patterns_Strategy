using UnityEngine;

[CreateAssetMenu(
    fileName = "New Armor Trade Behavior",
    menuName = "Armor Trade Behavior")]
public class ArmorTradeBehavior : ScriptableObject, ITradeBehavior
{
    public void Trade()
    {
        Debug.Log("Oh, I see you need armor. I have great options!");
    }
}