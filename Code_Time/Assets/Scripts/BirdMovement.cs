using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BirdMovement : MonoBehaviour
    
{

    // Start is called before the first frame update
    public float speed = 2f;
    public float force = 300f;
    void Start()
    {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
       
    }
    
}
