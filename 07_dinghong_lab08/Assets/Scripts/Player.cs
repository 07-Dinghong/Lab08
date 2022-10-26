using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    private int score;
    public Text scoretxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < 5.65f && transform.position.y > -3.63f)
        {
            float verticalInput = Input.GetAxis("Vertical");

            transform.position = transform.position + new Vector3(0, verticalInput * speed * Time.deltaTime, 0);
        }
       

      

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "score")
        {

        }
    }
}
