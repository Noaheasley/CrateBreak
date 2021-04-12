using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerBehaviour Player = other.GetComponent<PlayerBehaviour>();
        if (Player)
            Player.Destroy();
    }
}
