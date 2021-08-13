using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFoxy : MonoBehaviour
{
    public static MoveFoxy instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
    }
     public float walkSpeed;
     public float runSpeed;
     public float jumpSpeed;

 
     private float moveSpeed;


     public Rigidbody2D player;

    private SpriteRenderer playerR;

    public Animator HeroiAnim;
    
    public Vector2 direcao;

    private bool  gira;

    private bool dChao;

    private bool puloDuplo;

    private float yAtual;

    private float yMax;


    public Vector3 posInicial;

    private Vector3 checkpoint;

    private Vector3 retorno;






     

    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(12, 13);

        direcao =  new Vector2(0,0);

         yAtual = 0;
         yMax = -100;

         posInicial = transform.position;

         checkpoint = new Vector3(55, -1.6f , 0);

         retorno = posInicial;

        playerR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        player = GetComponent<Rigidbody2D>();

         VerificarY();

         LeituraTeclado();
        
         Animacao(direcao);

        DirecaoMovimento();

        StartCoroutine(GerandoDanoCor());
        

    }


     
    void LeituraTeclado()
    {

      
      if(Input.GetKeyDown(KeyCode.Space) && dChao == true)
      {
        player.velocity = new Vector2(player.velocity.x, jumpSpeed); 
        
       direcao =  new Vector2(0,1);

       puloDuplo = true;

      
      }

      if(Input.GetKeyDown(KeyCode.Space) && dChao == false && puloDuplo == true)
      {
        player.velocity = new Vector2(player.velocity.x, jumpSpeed); 
        
       direcao =  new Vector2(0,1);
       
       puloDuplo = false;

      }

   
      if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
      {
        player.velocity = new Vector2(-moveSpeed, player.velocity.y);
               
        gira = true;

        if(dChao)
        {
          direcao =  new Vector2(0,0);
        }


      }

      if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
      {
         player.velocity = new Vector2(moveSpeed, player.velocity.y);

          
         gira = false;

        if(dChao)
        {
          direcao =  new Vector2(0,0);
        }

         
      }

      if(Input.GetKey(KeyCode.LeftShift))
      {
        moveSpeed = runSpeed;
      }
      else
      {
        moveSpeed = walkSpeed;
      }
      


    }

  

  void Animacao(Vector2 dir)
  {
    HeroiAnim.SetFloat("x", dir.x);
    HeroiAnim.SetFloat("y", dir.y);
  }




   void DirecaoMovimento()
   {
     
     if(gira)
     { 
       transform.rotation = new Quaternion(0,180,0,0);
         
            
     }
     else
     {
       transform.rotation = new Quaternion(0,0,0,0);
       
      
      }


   }




private void OnCollisionStay2D(Collision2D other) 
{
  if(other.gameObject.CompareTag("chao"))
  {
    dChao = true;
   
  }
  
}

private void OnCollisionExit2D(Collision2D other) 
{
  if(other.gameObject.CompareTag("chao"))
  {
    dChao = false;
  }
  
}


void OnTriggerEnter2D(Collider2D other) 
{
  if(other.gameObject.CompareTag("destruir"))
  {
    transform.position = retorno;
  }

  if (other.gameObject.CompareTag("Destruir"))
   {
    Vida.instance.vida -= 1;
   }

        if (other.gameObject.CompareTag("checkpoint"))
  {
    retorno = checkpoint;
  }

}


 void VerificarY()
 {
  yAtual = transform.position.y;
          

          if(dChao == true)
          {
            direcao = new Vector2(0,0);
            yMax = -100;
          }

         if(yAtual > yMax)
         {
           yMax = yAtual;
         }

         if((yAtual == yMax) &&  dChao == false)
         {
           direcao = new Vector2 (0,1);       
         }

         if((yAtual != yMax) && dChao == false)
         {
           direcao = new Vector2 (0,-1);           
         }

 }


    private IEnumerator GerandoDanoCor()
    {
        if (ReceberDano.instance.invisivel)
        {
            playerR.color = Color.Lerp(Color.white, Color.clear, Mathf.PingPong(8 * Time.deltaTime, 0.5f));

            

        }
        else
        {
            yield return new WaitForSeconds(5f);
            playerR.color = new Color(1, 1, 1, 1);
        }
    }

}
