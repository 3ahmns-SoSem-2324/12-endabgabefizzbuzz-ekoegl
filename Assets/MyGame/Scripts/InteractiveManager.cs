using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InteractiveManager : MonoBehaviour
{
    public TMP_Text randomNbr;
    public Image right;
    public Image wrong;
    public TMP_Text correct;
    public TMP_Text incorrect;
    int randomNumber = 0;

    [System.Obsolete]
    void Start()
    {
        GenerateNumber();
        right.enabled = false;
        correct.enabled = false;
        wrong.enabled = false;
        incorrect.enabled = false;

        if (randomNumber % 3 == 0)
        {
            Debug.Log("Fizz");
        }

        else if(randomNumber % 5 == 0)
        {
            Debug.Log("Buzz");
        }

        else if(randomNumber % 3 == 0 && randomNumber % 5 == 0)
        {
            Debug.Log("FizzBuzz");
        }

        else
        {
            Debug.Log("nicht teilbar");
        }

    }

    [System.Obsolete]
    void GenerateNumber()
    { 
        randomNumber = Random.RandomRange(0, 1001);
        string randomString = randomNumber.ToString();
        randomNbr.text = randomString;
    }

    void Right()
    {
        right.enabled = true;
        correct.enabled = true;
    }

    void Wrong()
    {
        wrong.enabled = true;
        incorrect.enabled = true;
    }

    [System.Obsolete]
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space - neue nummer");
            GenerateNumber();
            right.enabled = false;
            correct.enabled = false;
            wrong.enabled = false;
            incorrect.enabled = false;
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("left - Fizz");
            if(randomNumber % 3 == 0)
            {
                Right();
            }

            else
            {
                Wrong();
            }

        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("right - Buzz");
            if (randomNumber % 5 == 0)
            {
                Right();
            }

            else
            {
                Wrong();
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("up - FizzBuzz");
            if (randomNumber % 3 == 0 && randomNumber % 5 == 0)
            {
                Right();
            }

            else
            {
                Wrong();
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("down - nicht teilbar");
            if (randomNumber % 3 == 0 && randomNumber % 5 == 0)
            {
                Wrong();
            }

            else
            {
                Right();
            }
        }

    }

}
