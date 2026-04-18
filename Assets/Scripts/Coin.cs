using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value = 1;

    private void OnTriggerEnter(Collider other)
    {
        GameManager.instance.CollectCoins(value);
        Destroy(gameObject);
    }
}
