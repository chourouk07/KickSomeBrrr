using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrBrainsBossScript : MonoBehaviour
{
    public Animator brainsAnimator;
    public int brainsHealth = 3;
    public Image equation;
    public Sprite[] equations;
    public int[] answers;
    public int position = 0;
    public int[] cubeNumbers;
    public GameObject Cube;
    public Transform[] positions;

    void Start()
    {
        //invoke threaten in 2s
        Invoke("Threaten", 2f);
    }


    void Update()
    {
        
    } 


    void Charge()
    {
        //trigger charge animation
        brainsAnimator.SetTrigger("Charge");
        //spawn equation in canvas
        equation.sprite = equations[position];
        //position++;
        //create 3 random numbers
        for(int i = 0; i < 3; i++)
        {
            cubeNumbers[i] = Random.Range(1, 100);

        }
        //make one of the numbers correct
        int x= Random.Range(0, 3);
        cubeNumbers[x] = answers[position];
        //spawn numbers
        for (int i = 0; i < cubeNumbers.Length; i++)
        {
            GameObject cube = Instantiate(Cube, positions[i].position, Quaternion.identity);
            cube.GetComponent<Text>().text = cubeNumbers[i].ToString();

        }

    }

    public void Hit(int number)
    { 
        if(number == answers[position])
        {
            //drbrains health--
            position++;
            //trigger hit animation
            brainsAnimator.SetTrigger("Hit");
            //invoke charge in 3s
            Invoke("Charge", 3f);

        }
        else
        {

        }
        //if(player correct)
        //{
        //}else
        //{
        //pablo health--
        //trigger threaten animation
        brainsAnimator.SetTrigger("Threaten");
        //invoke charge in 3s
        Invoke("Charge", 3f);
        //}

    }

    void Threaten()
    {
        //trigger threaten animation
        brainsAnimator.SetTrigger("Threaten");
        //invoke charge in 2s
        Invoke("Charge", 2f);
    }
}
