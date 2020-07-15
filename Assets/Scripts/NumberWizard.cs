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
        maxGuess += 1;
    }

    public void OnPressHigher()
    {
        minGuess = _guess;
        NextGuess();
    }

    public void OnPressLower()
    {
        maxGuess = _guess;
        NextGuess();
    }

    void NextGuess()
    {
        _guess = Random.Range(minGuess, maxGuess);
        guessText.text = _guess.ToString();
    }
}
