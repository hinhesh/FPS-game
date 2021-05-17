using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ennemyHealth : MonoBehaviour
{
    [SerializeField] float hitpoints = 100f;

    public void TakeDamage(float damage)
    {
        hitpoints -= damage;
        BroadcastMessage("OnDamageTaken");
        if (hitpoints <= 0)
            Destroy(gameObject);
    }
}
