using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrBrainsBossScript : MonoBehaviour
{
    public Animator brainsAnimator;
    public int brainsHealth = 3;
    public Text equation;




    void Start()
    {
        //invoke threaten in 2s
    }


    void Update()
    {
        
    } 


    void Charge()
    {
        //trigger charge animation
        //spawn equation in canvas
        //spawn numbers
    }

    void Hit()
    {
        /*
         * if(player correct)
         * {
         * drbrains health--
         * trigger hit animation
         * invoke charge in 3s
         * }else
         * {
         * pablo health--
         * trigger threaten animation
         * invoke charge in 3s
         * }
        */
    }

    void Threaten()
    {
        //trigger threaten animation
        //invoke charge in 2s
    }
}
