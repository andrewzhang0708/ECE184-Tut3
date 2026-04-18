using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public class OnCollectCoinsEventArgs: EventArgs{public int value;}
    public event EventHandler<OnCollectCoinsEventArgs> OnCollectCoins;
    private int coins;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
            coins = 0;
            OnCollectCoins?.Invoke(this, new OnCollectCoinsEventArgs{value = coins});
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CollectCoins(int value)
    {
        coins += value;
        Debug.Log(coins);
        OnCollectCoins?.Invoke(this, new OnCollectCoinsEventArgs{value = coins});
    }
}
