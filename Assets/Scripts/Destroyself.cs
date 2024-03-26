using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Destroyself : MonoBehaviour
{
   public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           // GameManager.Restart();
           var a = 1;
        }
        Destroy(gameObject);
        }
}
