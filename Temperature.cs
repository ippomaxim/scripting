using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    public Health health;

    public int playerDamage = 2;

    public float temperatureCurrent = 36.6f;

    public float temperatureNormal = 36.6f;

    public float temperatureCritical = 34f;

    public float freezeSpeed = 0.05f;

    public float freezeDamageTimer = 1;

    public float freezeDamageDeley = 2;

    // Update is called once per frame
    void Update()
    {
        temperatureCurrent -= freezeSpeed * Time.deltaTime;

        if(temperatureCurrent <= temperatureCritical)
        {
            if(freezeDamageTimer <= 0)
            {
                health.TakeDamage(playerDamage);

                freezeDamageTimer += freezeDamageDeley;
            }
            else
            {
                freezeDamageTimer -= Time.deltaTime;
            }
        }
    }
}