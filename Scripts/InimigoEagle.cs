using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoEagle : MonoBehaviour
{
   [SerializeField]
   private Rigidbody2D Aguia;

   [SerializeField]
   private float velocidade;

   [SerializeField]
   private Animator animDestroi;

    [SerializeField]
    private GameObject audioPrefab; 



    // Start is called before the first frame update
    void Start()
    {
        Aguia = GetComponent<Rigidbody2D>();

        Aguia.velocity = new Vector2(-velocidade, Aguia.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
       

      
    }



    IEnumerator OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("AguiaEsquerda"))
        {
          Aguia.velocity = new Vector2(velocidade, Aguia.velocity.y);
          transform.rotation = new Quaternion(0,180,0,0); 
        }

        if(other.gameObject.CompareTag("AguiaDireita"))
        {
           Aguia.velocity = new Vector2(-velocidade, Aguia.velocity.y);
           transform.rotation = new Quaternion(0,0,0,0); 
        }

        if(other.gameObject.CompareTag("Ataque"))
        {

            animDestroi.Play("Destruido");
            Instantiate(audioPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.3f);
            Destroy(gameObject);
           
        }

        yield return new WaitForSeconds(0.2f);
      
    }


   



}
     
