using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PushPhysics : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    private int score;
    public Text scoreText;

    void Start() 
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        scoreText.text = "Score: " + score.ToString();
    }

    void FixedUpdate() 
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3 (moveHorizontal, 0.01f, moveVertical);
        rb.AddForce(movement*speed);
    }

    void OnTriggerEnter(Collider other)
    {
        Renderer obj = other.gameObject.GetComponent<Renderer>();


        if (other.gameObject.CompareTag("Collectable"))
        {
            if (obj.material.color == Color.red)
            {
                score += 1;
            }
            else if (obj.material.color == Color.yellow)
            {
                score += 2;
            }
            else if (obj.material.color == Color.blue)
            {
                score += 3;
            }
            else if (obj.material.color == Color.green)
            {
                score += 4;
            }
            else if (obj.material.color == Color.white)
            {
                score += 5;
            }
            other.gameObject.SetActive(false);
            scoreText.text = "Score: " + score.ToString();
        }
    }
}