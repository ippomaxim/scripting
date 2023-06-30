using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public CoinsCounter coinsCounter;

    public Health health;

    public TextMeshProUGUI coinsCounterText;

    public Slider healthSlider;

    // Update is called once per frame
    void Update()
    {
        healthSlider.maxValue = health.maxHealth;

        healthSlider.value = health.health;

        coinsCounterText.text = coinsCounter.coins.ToString();
    }
}
