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
        StartCoroutine("Rotate");
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Rotate()
    {
        timetomove = Random.Range(0.2f, 1.5f);
        transform.Rotate(0,timetomove,0 *Time.deltaTime);
        yield return new WaitForSeconds(1);
    }


    IEnumerator Move()
    {
        for (int i = 0; 1 < 5; i++)
        {
            transform.position += transform.forward * Time.deltaTime * 2;
        }

        yield return new WaitForSeconds(1);
    }
}
