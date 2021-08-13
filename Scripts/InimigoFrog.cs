using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoFrog : MonoBehaviour
{ 
  [SerializeField]
  private float moveSpeed;

  [SerializeField]
  private float jumpSpeed;

  private Rigidbody2D sapoRB;

  private Vector2 direcao;

  [SerializeField]
  private Animator SapoAnim;


  void Start() 
  {
        sapoRB = GetComponent<Rigidbody2D>();

        direcao = new Vector2(-1 , -1);

        sapoRB.velocity = new Vector2(-moveSpeed, -jumpSpeed);
  }

  void Update()
  {
     if(direcao.x == -1)
     {
        sapoRB.velocity = new Vector2(-moveSpeed, sapoRB.velocity.y); 
     }
     else if(direcao.x == 1)
     {
       sapoRB.velocity = new Vector2(moveSpeed, sapoRB.velocity.y);   
     }
     else 
     {
        sapoRB.velocity = new Vector2(0, 0);    
     }



      if(direcao.y == -1)
     {
        sapoRB.velocity = new Vector2(sapoRB.velocity.x, -jumpSpeed); 
     }
     else if(direcao.y == 1)
     {
       sapoRB.velocity = new Vector2(sapoRB.velocity.x, jumpSpeed);  
     }
     else 
     {
        sapoRB.velocity = new Vector2(0, 0);    
     } 

    SapoAnim.SetFloat("y",direcao.y);     

  }


   
  IEnumerator OnTriggerEnter2D(Collider2D other)
  {
      if(other.gameObject.CompareTag("Baixo"))
      {
        direcao = new Vector2(direcao.x, 0);
        yield return new WaitForSeconds(3f);
        direcao = new Vector2(direcao.x , 1);
      }
      if(other.gameObject.CompareTag("Cima"))
      {
        direcao = new Vector2(direcao.x , -1);
      }
      if(other.gameObject.CompareTag("Esquerda"))
      {
         direcao = new Vector2(1 , direcao.y);
        transform.rotation = new Quaternion(0,180,0,0); 
      }
      if(other.gameObject.CompareTag("Direita"))
      {
        direcao = new Vector2(-1 , direcao.y);
        transform.rotation = new Quaternion(0,0,0,0); 
      }

      if(other.gameObject.CompareTag("Ataque"))
        {
            yield return new WaitForSeconds(0.3f);
            Destroy(gameObject);      
        }
        
      yield return new WaitForSeconds(0.2f);
      
     
  } 


   

}
