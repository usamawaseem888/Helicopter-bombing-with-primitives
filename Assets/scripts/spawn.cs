using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] b;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnm", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
        

        
    }
    void spawnm()
    {
        int index = Random.Range(0, b.Length);
        float xr = Random.Range(-22, -16);
        float zz = Random.Range(22, 12);
        Vector3 v = new Vector3(zz, 0, xr);
        Instantiate(b[index], v, b[index].transform.rotation);
    }
}
