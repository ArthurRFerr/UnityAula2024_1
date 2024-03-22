using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float velocidade = 10;
    // Start is called before the first frame update
    void Start()
    {
      
        float x = Random.Range(0, 2) == 0 ? -1 : 1;

        //mesma coisa que o de cima
        /* 
         float x1 = Random.Range(0, 2);
        if (x1==0)
        {
            x1 = -1;
        }
        else
        {
            x1 = 1;
        }
        */

        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        GetComponent<Rigidbody>().velocity = new Vector2(velocidade*x, velocidade*y); //vai pegar um componente de onde o script estiver


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
