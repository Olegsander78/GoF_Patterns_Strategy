using UnityEditor;

public class ArmorTradeBehaviorAsset
{
    [MenuItem("Assets/Create/Armor Trade Behavior")]
    public static void CreateAsset()
    {
        ScriptableObjectUtility.CreateAsset<ArmorTradeBehavior>();
    }
}
