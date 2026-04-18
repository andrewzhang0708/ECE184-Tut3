using UnityEngine;

public class CoinDoor : MonoBehaviour
{
    
    private Door door;

    private void Awake()
    {
        door = GetComponent<Door>();
    }
    private void Start()
    {
        GameManager.instance.OnCollectCoins += CheckOpen;
    }

    private void CheckOpen(object sender, GameManager.OnCollectCoinsEventArgs e)
    {
        if(e.value >= 10)
        {
            door.Open();
            enabled = false;
        }
        // else
        // {
        //     door.Close();
        // }
    }
}
