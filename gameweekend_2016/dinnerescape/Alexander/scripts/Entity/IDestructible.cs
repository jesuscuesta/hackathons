using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(DestructibleInfo))]
public abstract class IDestructible : ICollisionable
{
        private DestructibleInfo healthInfo;

    public void DoDamage(GameObject caller, float damage)
    {
        OnDamageRecieved(damage, caller);
    }

    //Function to call when going to recieve damage. Taker
    protected virtual void OnDamageRecieved(float damage, GameObject caster)
    {
        this.healthInfo.currentHealth -= damage;
        if(this.healthInfo.currentHealth <= 0)
        {
            this.healthInfo.currentHealth = 0;
            OnKilled(caster);
        }
    }

    protected virtual void OnKilled(GameObject killer)
    {

    }
}
