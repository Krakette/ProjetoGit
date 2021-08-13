using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceberDano : MonoBehaviour
{
    public static ReceberDano instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
    }

    public bool invisivel;



 



    // Start is called before the first frame update
    void Start()
    {
      
        invisivel = false;

        Physics2D.IgnoreLayerCollision(12, 13);


    }

    // Update is called once per frame
    void Update()
    {
       if(invisivel)
        {
            Physics2D.IgnoreLayerCollision(9, 10, true);
        }
        else 
        {
            Physics2D.IgnoreLayerCollision(9, 10, false);
        }
   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.CompareTag("Inimigo") && invisivel == false)
        {

            StartCoroutine(SemDano());
            Vida.instance.vida -= 1;
        }
        
    }


    private IEnumerator SemDano()
    {
        invisivel = true;
        yield return new WaitForSeconds(3f);
        invisivel = false;
    }


}
