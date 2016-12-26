using UnityEngine;
using System.Collections;

public class Enemy : IDestructible {

    public enum EnemyState {
        IDDLE,
        PREPARING,
        ATTACKING
    };
    public float movementSpeed;
    public float attackRange;
    public int damage;
    public bool selfDestruct = true;
    public int timeToDestroy = 15;
    public EnemyState state = EnemyState.IDDLE;

    new void Start()
    {
        movementSpeed = gameObjects.speedBackground;
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position + new Vector3(0, 1.5f, 0), transform.right * (-attackRange), Color.red);

        if(Physics.Raycast(transform.position + new Vector3(0,1.5f,0), transform.right * (-attackRange), out hit))
        {
            OnHit(hit.collider.gameObject, Vector3.Distance(hit.point, transform.position));
        }
    }
	// Update is called once per frame
	void Update ()
    {
        if (IsAlive())
        {
            //this.transform.Translate((-1) * movementSpeed * Time.deltaTime, 0f, 0f);
        }
	}

    void PrepareAttack(GameObject target)
    {
        Player player = target.GetComponent<Player>();
        if (player != null)
            player.OnRange(this);
        state = EnemyState.PREPARING;
    }
    void Attack(GameObject tarjet)
    {
        state = EnemyState.ATTACKING;
        IDestructible destr = tarjet.GetComponent<IDestructible>();
        if (destr != null)
        {
            destr.Damage(transform.gameObject, 1);
            AttackDone();
        } else Debug.LogWarning(gameObject.name + " <" + gameObject.tag + ">: Trying to Attack non-destructible (" + tarjet.name+"). Ignoring.");
    }
    void AttackDone()
    {
        DestroyImmediate(transform.gameObject);
    }
    void OnHit(GameObject hit, float distance)
    {
        if (distance < attackRange)
        {
            if(state == EnemyState.PREPARING)
                Attack(hit);
        } else if(distance - 1 < attackRange)
        {
            if(state == EnemyState.IDDLE)
                PrepareAttack(hit);
        }
            

    }
}
