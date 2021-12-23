
using UnityEngine;

public class Target : MonoBehaviour
{

    public float health = 30f;

    public GameObject someObject;
   

    public void TakeDamage(float amount)
    {

        health -= amount;
        

        if (health <= 0f)
        {
            Gun gun = someObject.GetComponent<Gun>();
            gun.ammo += 10;
            Die();
        }
        
    }
    
    void Die()
    {
        
        Destroy(gameObject);
        
    }
}
