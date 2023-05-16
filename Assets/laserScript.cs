using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class laserScript : MonoBehaviour
{
    int health;
    public Movement playerScript;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            //reset scene
            Debug.Log("Game Over");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        /*
        if (other.CompareTag("HitPoint"))
        {
            health = playerScript.lifePoints;
            health--;
            playerScript.LifePoints(health);
        }
        */
    }
}
