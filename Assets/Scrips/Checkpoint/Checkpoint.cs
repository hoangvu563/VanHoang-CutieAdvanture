using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player" && PlayerHeartSystem.life>0)
        {
            PlayerMove.LastCheckPoint = transform.position;
        }
    }
}