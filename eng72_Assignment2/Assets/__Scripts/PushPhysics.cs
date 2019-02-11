using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PushPhysics : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public Text scoreText;
    Score score = new Score();

    void Start() 
    {
        rb = GetComponent<Rigidbody>();
        scoreText.text = "Score: " + score.GetScore().ToString();
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
                score.SetScore(score.GetScore() + 1);
            }
            else if (obj.material.color == Color.yellow)
            {
                score.SetScore(score.GetScore() + 2);
            }
            else if (obj.material.color == Color.blue)
            {
                score.SetScore(score.GetScore() + 3);
            }
            else if (obj.material.color == Color.green)
            {
                score.SetScore(score.GetScore() + 4);
            }
            else if (obj.material.color == Color.white)
            {
                score.SetScore(score.GetScore() + 5);
            }
            other.gameObject.SetActive(false);
            scoreText.text = "Score: " + score.GetScore().ToString();
        }
    }
}