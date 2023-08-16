using UnityEngine;

public class NoTrade : ITradeBehavior
{
    public void Trade()
    {
        Debug.Log("I don't have any items for you today.");
    }
}
