using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class player : MonoBehaviour
{
    public static int score = 0;
    float speed = 15f;
    public GameObject b;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizon = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        transform.Translate(Vector3.back*speed*Time.deltaTime*horizon);
        transform.Translate(Vector3.right*speed*Time.deltaTime*vert);
        Vector3 v=new Vector3(transform.position.x,0,transform.position.z);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(b,transform.position,b.transform.rotation);
        }
        boundary();
        boundaryz();
    }
    private void boundaryz()
    {
        if(transform.position.z > -15)
        {
            transform.position=new Vector3(transform.position.x,transform.position.y,-15f);
        }
        if(transform.position.z < -22f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -22f);
        }
    }
    void boundary()
    {
        if(transform.position.x> 22 )
        {
            transform.position=new Vector3(22,transform.position.y,transform.position.z);   
        }
        if (transform.position.x < 10)
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }
    }
}
