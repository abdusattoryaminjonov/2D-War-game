using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid : MonoBehaviour
{

    public GameObject ExplosionPrefab;
    public GameObject ExplosionSound;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.name.Equals("Player_Projectile(Clone)"))
        {
            
            Instantiate(ExplosionPrefab, collision.gameObject.transform.position, Quaternion.identity);
            Instantiate(ExplosionSound, collision.gameObject.transform.position, Quaternion.identity);
            
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }


}
