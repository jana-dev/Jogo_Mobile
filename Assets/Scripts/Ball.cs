using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public bool isRight;
    public float speed;

    public Transform pointR;
    public Transform pointL;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRight) //se verdadeiro vai para a direita
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else //se falso vai para a esquerda
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if (Input.GetMouseButtonDown(0))
        {
            isRight = !isRight;
        }


        if(Vector2.Distance(transform.position, pointL.position) < 0.1f || Vector2.Distance(transform.position, pointR.position) < 0.1f)
        {
            isRight = !isRight;
        }
        
    }
}
