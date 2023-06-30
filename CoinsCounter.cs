using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCounter : MonoBehaviour
{
    //Число собранных монет
    public int coins;

    public void CollectCoins()
    {
        coins++;
    }
}
