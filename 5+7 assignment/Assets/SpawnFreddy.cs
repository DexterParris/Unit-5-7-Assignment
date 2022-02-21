using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFreddy : MonoBehaviour
{
    public GameObject freddy;
    // Start is called before the first frame update
    void Start()
    {
        SpawnObject();
        StartCoroutine("spawnmanager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnmanager()
    {

        for(int i = 0; i < 75; i++)
        {
            yield return new WaitForSeconds(4.5f);
            SpawnObject();
        }
        yield return new WaitForSeconds(1);
    }

    public void SpawnObject()
    {
        Instantiate(freddy, new Vector3(0,0,0), Quaternion.identity);
    }
}
