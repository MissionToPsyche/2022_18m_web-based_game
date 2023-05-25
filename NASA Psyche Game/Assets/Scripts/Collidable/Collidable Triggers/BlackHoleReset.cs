using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class BlackHoleReset : Collidable {
    public Rigidbody2D player;

    [SerializeField] private float gravitationalForce = 0.5f;

    protected override void OnCollide(Collider2D coll) {
        if (coll.name == "Psychenaut") {
            // play some sort of animation for the screen to reset here
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            // Debug.Log("contacting black hole");

            GameObject playerObj = GameObject.Find("Psychenaut");
            playerObj.transform.position = new Vector3(-1.13f, -18.5f, 0f);
        }
    }

    private void FixedUpdate()
    {
        // Since transform.position is a Vector3 but bird.position is a Vector2 you now have to cast
        var directionOfPlayerFromBlackHole = ((Vector2) transform.position - player.position).normalized;
        var vectorDistanceFromBlackHole = ((Vector2) transform.position - player.position);
        var distanceFromBlackHole = Math.Sqrt(Math.Pow(vectorDistanceFromBlackHole.x, 2) + Math.Pow(vectorDistanceFromBlackHole.y, 2));
        // Debug.Log("Distance: " + distanceFromBlackHole);
        // Debug.Log("x val: " + directionOfPlayerFromBlackHole.x);
        // Debug.Log("y val: " + directionOfPlayerFromBlackHole.y);

        if (distanceFromBlackHole <= 0.75) {
            // Adds the force towards the center
            player.AddForce(directionOfPlayerFromBlackHole * gravitationalForce);
        }
        else {
            // player.AddForce(new Vector2(0f, 0f));
            player.velocity = Vector2.zero;
        }
    }
}