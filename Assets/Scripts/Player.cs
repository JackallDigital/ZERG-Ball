using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float turnSpeed;

    public int health;
    int score;

    public TMP_Text healthText;
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * turnSpeed * Input.GetAxisRaw("Horizontal") * Time.deltaTime);
    }

    public void TakeDamage() {
        health--;
        healthText.text = "Health " + health;

        if(health <= 0) {
            SceneManager.LoadScene("Game");
        }
    }

    public void AddScore() {
        score++;
        scoreText.text = "Score " + score;
    }
}
