using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float Health = 500f;
    // Start is called before the first frame update

    public void TakeDamage(float damage)
    {
        Health -= damage;
        Debug.Log(Health);
        if (Health <= 0)
        {
            GetComponent<deathhandler>().HandleDeath();
        }
    }
}
