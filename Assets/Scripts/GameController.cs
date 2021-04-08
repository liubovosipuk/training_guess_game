using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    private int guessNumber; 

    private int countOfGuesses;

    [SerializeField] private GameObject btn,
                                        inputButton;

    [SerializeField] private GameObject panel;
    [SerializeField] private Sprite winBG,
                                    defaultBG;

    [SerializeField] private InputField input;

    [SerializeField] private Text textGameMessage; 



    private void Awake() {
        //input = GameObject.Find("InputField").GetComponent<InputField>(); // instead of attaching in Inspector
        guessNumber = Random.Range(0, 100);
        textGameMessage.text = "Guess a number between 0 to 100";

    }



    public void GetInput(string guess) {
        CompareGuessesNumbers(int.Parse(guess));
        input.text = "";
        countOfGuesses++;
    }



    private void CompareGuessesNumbers(int guess) {
        if (guess == guessNumber) {
            Debug.Log("equal is Working");
            textGameMessage.text = "You guessed correctly, your number is " + guess + " It took you " + countOfGuesses + " Guess(es) \nDo you wanna Play again?";
            panel.GetComponent<Image>().sprite = winBG; // change BG 
            inputButton.SetActive(false);
            btn.SetActive(true);

        } else if (guess < guessNumber) {
            Debug.Log("less is Working");
            textGameMessage.text = "Your guess number is less than Number you are trying to guess";


        } else if (guess > guessNumber) {
            Debug.Log("greater is Working");
            textGameMessage.text = "Your guess number is greater than Number you are trying to guess";
        }
    }


    public void PlayAgain() {
        SceneManager.LoadScene(0);
        countOfGuesses = 0;

    }



} // GameController 


































