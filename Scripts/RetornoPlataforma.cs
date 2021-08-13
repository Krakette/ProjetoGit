using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetornoPlataforma : MonoBehaviour
{
     [SerializeField] 
     private GameObject plataforma;

     private Vector3 posInicial;

    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;

        Physics2D.IgnoreLayerCollision(8, 11);
        Physics2D.IgnoreLayerCollision(10, 11);
    }

    // Update is called once per frame
    
   IEnumerator OnTriggerEnter2D(Collider2D other)
   {
       if(other.gameObject.CompareTag("destruir"))
       {      
                 
           yield return new WaitForSeconds(4f);
           Instantiate(plataforma,posInicial,Quaternion.identity); 
           Destroy(gameObject);
       }
       
   }

}
