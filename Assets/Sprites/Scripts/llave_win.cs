using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class llave_win : MonoBehaviour
{
    
   private void OnTriggerEnter2D(Collider2D collision)
      {
        if (collision.gameObject.tag == "Player")
        {
            WIN.show();

            Destroy(gameObject);
        }
       }
    
}
