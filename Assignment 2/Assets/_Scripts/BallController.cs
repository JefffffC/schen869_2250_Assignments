using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour { 

    private Rigidbody ballRigidBody; // Rigidbody variable in order to push it using AddForce
    private int playerScore;
    public Text playerScoreCounter;

    // Start is called before the first frame update
    void Start()
    {
        ballRigidBody = GetComponent<Rigidbody>();
        playerScore = 0;
        setPlayerScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        //variables for horizontal and vertical input by player is updated each frame and translated to ball object movement using AddForce function
        float pushHorizontal = Input.GetAxis("Horizontal");
        float pushVertical = Input.GetAxis("Vertical");
        Vector3 ballMovement = new Vector3(pushHorizontal, 0.0f, pushVertical);
        ballRigidBody.AddForce(ballMovement);
    }

    void OnTriggerEnter(Collider other) //Used to add to the score upon collision with an pickup object with the "pickup" tag
    {
        if (other.gameObject.CompareTag("pickup")) { //only execute code if the collision is with a pickup object
            playerScore = playerScore + other.gameObject.GetComponent<PickupPoints>().Points; //use getter function of object property class to retrieve and add score
            setPlayerScoreText();
            Destroy(other.gameObject); // destroy the picked up object
        }
    }

    void setPlayerScoreText () // use player score update function to avoid code repetition
    {
        playerScoreCounter.text = "Score: " + playerScore.ToString();
    }
}


