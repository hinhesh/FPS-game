using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    [SerializeField] Camera FPCamera;
    [SerializeField] float range = 100f;
    [SerializeField] ParticleSystem muzzleFlash;
    [SerializeField] GameObject explosion;
    float damage = 30f;
    void Update()
    {
        if (Input.GetKey(KeyCode.N))
            {
                Shoot();
            }
        
    }
    private void Shoot()
    {
        PlayMuzzleFlash();
        ProcessRaycast();
    }
    private void PlayMuzzleFlash()
    {
        muzzleFlash.Play();

    }
    private void ProcessRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range)== true)
        {
            CreateHitImpact(hit);
            ennemyHealth target = hit.transform.GetComponent<ennemyHealth>();
            if (target == null)
                return;
            target.TakeDamage(damage);

        }
        else
            return;
            
    }
    private void CreateHitImpact(RaycastHit hit)
    {
        GameObject impact =Instantiate(explosion, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(impact, 0.1f);
    }
}
