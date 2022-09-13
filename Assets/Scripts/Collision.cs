using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collision : MonoBehaviour
{
    
    public GameObject ball2;
    public GameObject ball3;
    public GameObject ball4;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame


    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        
      

        if (collision.gameObject.CompareTag("Large"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

            Instantiate(ball2, transform.position, ball2.transform.rotation);
            Instantiate(ball2, transform.position, ball2.transform.rotation);
            Debug.Log("work");
        }
        else if (collision.gameObject.CompareTag("Medium"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Instantiate(ball3, transform.position, ball3.transform.rotation);
            Instantiate(ball3, transform.position, ball3.transform.rotation);
            Debug.Log("On");

        }
        else if (collision.gameObject.CompareTag("Small")) {
            Destroy(collision.gameObject);
            Destroy (gameObject);
            Instantiate(ball4, transform.position, ball4.transform.rotation);
            Instantiate(ball4, transform.position, ball4.transform.rotation);
        }
        else if (collision.gameObject.CompareTag("Smaller"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }



    }

}