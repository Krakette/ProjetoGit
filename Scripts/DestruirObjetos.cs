using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirObjetos : MonoBehaviour
{
    void Start()
    {
        Physics2D.IgnoreLayerCollision(12, 13);
    }

        private void OnTriggerEnter2D(Collider2D other) 
  {
      if(other.gameObject.CompareTag("Destruir"))
      {
          Destroy(gameObject);
      }
      
  }

}
