using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Numberer : MonoBehaviour
{
    public Text guessText;
    int max = 1000;
    int min = 1;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        NextGuess();
        WriteGuess();
    }

    private void WriteGuess()
    {
        guessText.text = guess.ToString();
    }

    private void NextGuess()
    {
        guess = Random.Range(min, max);
    }

    public void onPressHigher()
    {
        min = guess;
        NextGuess();
        WriteGuess();

    }

    public void onPressLower()
    {
        max = guess;
        NextGuess();
        WriteGuess();
    }

    public void onPressCorrect()
    {
        SceneManager.LoadScene(2);
    }
}
