using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ennemyAttack : MonoBehaviour
{
    [SerializeField] float damage = 40f;
    PlayerHealth player;
    void Start()
    {
        player = FindObjectOfType<PlayerHealth>();
    }
    public void AttackHitEvent()
    {
        if (player == null)
            return;
        player.TakeDamage(damage);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
