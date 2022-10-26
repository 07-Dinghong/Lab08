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
        scoretxt.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0, verticalInput * speed * Time.deltaTime, 0);
        if (transform.position.y >= 5.65f )
        {
            transform.position = transform.position + new Vector3(0, -0.5f, 0);
        }
        else if (transform.position.y <= -3.63f)
        {
            transform.position = transform.position + new Vector3(0, 0.5f, 0);
        }
       

      

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "score")
        {
            score++;
            scoretxt.text = "Score: " + score;
        }

        if (other.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene(1);
        }
    }
}
