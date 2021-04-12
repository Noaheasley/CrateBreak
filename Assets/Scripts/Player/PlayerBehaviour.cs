using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public void Destroy()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        //EnemyBehaviour Enemy = other.GetComponent<EnemyBehaviour>();
        //if (Enemy)
        //    Enemy.Destroy();
        if (other.CompareTag("Wall"))
            Destroy();
    }

}
