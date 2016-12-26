using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(DestructibleInfo))]
public abstract class IDestructible : ICollisionable
{
    private DestructibleInfo healthInfo;

    public virtual void Start()
    {
        
    }
    public int Lifes
    {
        get
        {
            if(healthInfo == null)
                healthInfo = gameObject.GetComponent<DestructibleInfo>();
            return healthInfo.currentHealth;
        }
        set
        {
            if (healthInfo == null)
                healthInfo = gameObject.GetComponent<DestructibleInfo>();
            healthInfo.currentHealth = value;
        }
    }

    public void Damage(GameObject caller, int damage)
    {
        OnDamageRecieved(damage, caller);
    }

    public bool IsAlive()
    {
        return (Lifes > 0);
    }

    //Function to call when going to recieve damage. Taker
    protected virtual void OnDamageRecieved(int damage, GameObject caster)
    {
        Debug.Log(gameObject.name +" <" +gameObject.tag + ">: DAMAGE_RECEIVED. CURRENT LIFE: " + Lifes);
        this.healthInfo.currentHealth -= damage;
        if(this.healthInfo.currentHealth <= 0)
        {
            this.healthInfo.currentHealth = 0;
            OnKilled(caster);
        }
    }

    protected virtual void OnKilled(GameObject killer)
    {
        Debug.Log(gameObject.name + " <" + gameObject.tag + ">: KILLED");
    }
}
