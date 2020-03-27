using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] int damage = 100;
    [SerializeField] AudioClip hitNoise;
    [SerializeField] [Range(0,1)] float hitVolume = .5f;

    public int GetDamage()
    {
        return damage;
    }

    public void Hit()
    {
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(hitNoise, Camera.main.transform.position, hitVolume);
    }
}
