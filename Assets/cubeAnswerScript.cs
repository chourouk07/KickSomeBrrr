using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubeAnswerScript : MonoBehaviour
{
    public float moveSpeed = 5f; // The speed at which the character moves
    public int number;
    public DrBrainsBossScript drBrainsBossScript;
    // Start is called before the first frame update
    void Start()
    {
        number = int.Parse(gameObject.GetComponent<Text>().text);
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
    }

    void MoveForward()
    {
        transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            //spawn particle effect
            //check for hit;
            drBrainsBossScript.Hit(number);

        }
    }
}
