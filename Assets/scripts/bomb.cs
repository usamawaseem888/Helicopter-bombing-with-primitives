using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // transform.Translate(Vector3.down * speed * Time.deltaTime);
        StartCoroutine(po());
    }

    IEnumerator po()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("target"))
        {
            Destroy(gameObject); 
            Destroy(collision.gameObject);
            player.score++;
        }
        if (collision.gameObject.CompareTag("ground"))
        {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }
    }
}
