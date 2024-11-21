using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class respawn : MonoBehaviour
{
    [SerializeField] GameObject ball;
    private Rigidbody rb;
    public GameObject over;
     private int n = 0;
    Score score;
    // Start is called before the first frame update
    void Start()
    {
        rb = ball.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("ball"))
        {
            ball.transform.position = new Vector3(-2f, 0.57f, 2);
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            Debug.Log("contact");
            n++;
            Debug.Log(n);
            if (n == 3)
            {
                // game over
                over.gameObject.SetActive(true);
                n = 0;
               

            }
        }
    }
    public void exit()
    {
        Application.Quit();
    }
   
}