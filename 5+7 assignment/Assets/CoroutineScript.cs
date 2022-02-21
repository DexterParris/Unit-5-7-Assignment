using System.Collections;
using System.Collections.Generic;
using static UnityEngine.Random;
using UnityEngine;

public class CoroutineScript : MonoBehaviour
{
    float timetomove = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        StartCoroutine("Dostuff");
    }


    // Update is called once per frame
    void Update()
    {

    }
    

    IEnumerator Dostuff()
    {
        yield return new WaitForSeconds(1);
        
        for(int i = 0; i < 75; i++)
        {
            StartCoroutine("Rotate");
            yield return new WaitForSeconds(1.5f);
            StopCoroutine("Rotate");
            StartCoroutine("Move");
            yield return new WaitForSeconds(3);
            StopCoroutine("Move");
        }

        yield return new WaitForSeconds(1);

    }


    IEnumerator Rotate()
    {
        int moveamount = 1;
        timetomove = Random.Range(0.2f, 1.5f);
        bool leftOrRight = (Random.value > 0.5f);

        if(leftOrRight)
        {
            moveamount = -1;
        }
        

        float timePassed = 0;
        print(timetomove);

        while(timePassed < timetomove)
        {
            transform.Rotate(new Vector3(0,moveamount,0 * Time.deltaTime));
            yield return new WaitForSeconds(0.001f);
            timePassed += Time.deltaTime;
        }

        yield return null;
        
    }


    IEnumerator Move()
    {
        float timePassed = 0;
        float timetomove = Random.Range(0.5f,3f);

        while(timePassed < timetomove)
        {
            transform.position += transform.forward * Time.deltaTime * 2;

            yield return new WaitForSeconds(0.001f);
            timePassed += Time.deltaTime;
        }

        yield return new WaitForSeconds(1);
    }
}
