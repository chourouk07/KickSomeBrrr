using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;

public class BossFight : MonoBehaviour
{
    public Sprite[] mathEq;
    public int[] answers;
    public GameObject chosenEq;
    public GameObject displayEquation;
    public TextMeshProUGUI displayanswer1;
    public TextMeshProUGUI displayanswer2;
    public TextMeshProUGUI displayanswer3;

    public int[] possibleAnswers;
    public int CorrPos;


    private void Start()
    {
        ChooseEq();
    }
    public void ChooseEq()
    {
        for (int i = 0; i < mathEq.Length; i++)
        {
            displayEquation.GetComponent<Image>().sprite = mathEq[i];
            CorrPos = Random.Range(0,2);
            possibleAnswers[CorrPos] = answers[i];

            // Add random integers in the remaining empty places
            for (int j = 0; j < possibleAnswers.Length; j++)
            {
                if (j != CorrPos && possibleAnswers[j] == 0)
                {
                    int randomInt = GetRandomIntExcept(possibleAnswers, answers[i]);
                    possibleAnswers[j] = randomInt;
                }
            }

            // Display the possible answers on the corresponding UI elements
            displayanswer1.text = possibleAnswers[0].ToString();
            displayanswer2.text = possibleAnswers[1].ToString();
            displayanswer3.text = possibleAnswers[2].ToString();
        }
    }

    private int GetRandomIntExcept(int[] array, int exceptValue)
    {
        int randomInt;
        do
        {
            randomInt = Random.Range(1, 100); // Modify the range based on your requirements
        } while (System.Array.IndexOf(array, randomInt) != -1 || randomInt == exceptValue);
        return randomInt;
    }

}
