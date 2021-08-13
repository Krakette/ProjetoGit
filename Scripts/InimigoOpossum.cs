using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoOpossum : MonoBehaviour
{
   




    [SerializeField]
    private float moveSpeed;

    private Rigidbody2D inimigoRB;

    private bool moveF;
    
    [SerializeField]
    private Transform limite;

    [SerializeField]
    private Animator animDestroi;

    [SerializeField]
    private GameObject audioPrefab;



    // Start is called before the first frame update
    void Start()
    {
       Physics2D.IgnoreLayerCollision(10,10);
      

        inimigoRB = GetComponent<Rigidbody2D>();

        moveF = true;

        
    }

    // Update is called once per frame
    void Update()
    {

        if(moveF)
        {
          inimigoRB.velocity = new Vector2(-moveSpeed, inimigoRB.velocity.y);
        }
        else
        {
          inimigoRB.velocity = new Vector2(moveSpeed,inimigoRB.velocity.y);
        }

        
    }


    void Flip()
    {
        moveF = ! moveF;

        Vector3 temp = transform.localScale;

        if(moveF)
        {
            temp.x = Mathf.Abs(temp.x);
        }   
        else
        {
           temp.x = -Mathf.Abs(temp.x); 
        }

        transform.localScale = temp;
    }



    private void OnTriggerExit2D(Collider2D collision)
    {
       if(collision.gameObject.CompareTag("chao"))
        {
            Flip();
        }
    }

  

}
