using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoxScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer sr;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        StartCoroutine(move());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator move()
    {
        for(int i = 0; 1<10; i++)
        {
            rb.velocity = new Vector2(2,0);
            yield return new WaitForSeconds(1);
            rb.velocity = new Vector2(-2, 0);
        }

        
    }

    IEnumerator fade()
    {

        yield return new WaitForSeconds(0.01f);
    }
}
