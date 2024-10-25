using UnityEngine;
using UnityEngine.UI;

public class cubeAnswerScript : MonoBehaviour
{
    public float moveSpeed = 5f; // The speed at which the character moves
    public int number;
    public Text text;
    public DrBrainsBossScript drBrainsBossScript;

    private void Awake()
    {
        //find drbrainscript refrence
        drBrainsBossScript = GameObject.Find("DrBrains").GetComponent<DrBrainsBossScript>();
        //number = int.Parse(gameObject.GetComponent<Text>().text);
        number = int.Parse(text.text);
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
            Debug.Log("box hit player");
            //spawn particle effect
            //check for hit;
            drBrainsBossScript.Hit(number);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            //spawn particle effect
            //check for hit;
            drBrainsBossScript.Hit(number);
            Debug.Log(number);

        }
    }
}
