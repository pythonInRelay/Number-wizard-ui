using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] int minGuess;
    [SerializeField] int maxGuess;
    [SerializeField] private TextMeshProUGUI guessText;
    int _guess;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        minGuess = _guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        maxGuess = _guess - 1;
        NextGuess();
    }

    void NextGuess()
    {
        _guess = Random.Range(minGuess, maxGuess + 1);
        guessText.text = _guess.ToString();
    }
}
