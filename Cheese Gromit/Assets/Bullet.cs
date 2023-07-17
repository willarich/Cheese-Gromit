using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponent))
        {
            enemyComponent.TakeDamage(1);
        }
        Destroy(gameObject);
    }

    //public Rigidbody2D rigidBody;

    //private void OnTriggerEnter2D(Collider2D collision)
    //{

        
    //        switch (collision.gameObject.tag)
    //        {
    //            case "Wall":
    //                Destroy(gameObject);
    //                break;
    //            case "Enemy":
    //                //Enemy takes damage
    //                //Handle collision
    //                Destroy(gameObject);
    //                break;
    //        }
    //}
}
