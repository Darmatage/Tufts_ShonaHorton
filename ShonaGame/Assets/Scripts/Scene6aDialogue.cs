using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene6aDialogue : MonoBehaviour
{
    public int primeInt = 1;
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public Text Char3name;
    public Text Char3speech;
    public GameObject DialogueDisplay;
    GameObject ArtChar1;
    public GameObject ArtChar1a;
    public GameObject ArtChar1b;
    public GameObject ArtChar1c;
    public GameObject ArtChar2a;
    public GameObject ArtChar3a;
    public GameObject ArtBG1;
    public GameObject nextButton;
    public GameObject nextScene;
    public string playerName;
    public GameHandler gameHandler;
    // Start is called before the first frame update
    void Start()
    {
        string pNameTemp = gameHandler.GetName();
        playerName = pNameTemp;
        DialogueDisplay.SetActive(false); 
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(false);
        ArtChar2a.SetActive(false);
        ArtChar3a.SetActive(false);
        ArtBG1.SetActive(true);
        nextScene.SetActive(false);
        if (GameHandler.collarColor == 0){
            if (GameHandler.ateTowel == 0){
                ArtChar1 = ArtChar1a;
            }
            else{
                ArtChar1 = ArtChar1c;
            }
        }
        else{
            ArtChar1 = ArtChar1b;
        }
        ArtChar1.SetActive(false);
        nextButton.SetActive(true);
    }

    // Update is called once per frame
    public void Next()
    {
        primeInt = primeInt + 1;
        if (primeInt == 1){

        }
        else if (primeInt == 2){
            DialogueDisplay.SetActive(true);
            ArtChar1.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "Ooo the lake!! Look at all the little ducks!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 3){
            ArtChar1.SetActive(false);
            ArtChar3a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Woah careful, " + playerName + "! Don’t splash me!";
        }
        else if (primeInt == 4){
            ArtChar3a.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "Throw my toy, throw my toy!!";
            Char3name.text = "";
            Char3speech.text = "";
            if (GameHandler.nice == 1){
                primeInt = 10;
            }
            else{
                primeInt = 15;
            }
        }
        else if (primeInt == 11){
            ArtChar2a.SetActive(true);
            ArtChar1.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Ollie";
            Char2speech.text = "Hey " + playerName + "! It’s me, Ollie!";
        }
        else if (primeInt == 12){
            ArtChar1.SetActive(true);
            ArtChar2a.SetActive(false);
            Char1name.text = playerName;
            Char1speech.text = "Oh my goodness!! Hi Ollie!! Wanna play with my toy with me?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 13){
            ArtChar2a.SetActive(true);
            ArtChar1.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Ollie";
            Char2speech.text = "Yes, let's do it!!";
            primeInt = 20;
        }
        else if (primeInt == 16){
            ArtChar3a.SetActive(true);
            ArtChar1.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Ok " + playerName + ", go get it!";
        }
        else if (primeInt == 17){
            ArtChar1.SetActive(true);
            ArtChar3a.SetActive(false);
            Char1name.text = playerName;
            Char1speech.text = "I got it, I got it!!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 18){
            ArtChar3a.SetActive(true);
            ArtChar1.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Good job buddy!";
            primeInt = 20;
        }
        else if (primeInt == 21){
            ArtChar2a.SetActive(false);
            ArtChar3a.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "This is so fun!!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 22){
            ArtChar1.SetActive(false);
            ArtChar3a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "You really love the park, don’t you " + playerName + "?";
        }
        else if (primeInt == 23){
            ArtChar3a.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "Yes yes yes! This is the best day ever!!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 24){
            ArtChar3a.SetActive(true);
            ArtChar1.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "I’m glad you’re having a good time, buddy. Come on, let's go play with the ducks some more!";
        }
        else if (primeInt == 25){
            ArtChar3a.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "Ok!!";
            Char3name.text = "";
            Char3speech.text = "";

            nextButton.SetActive(false);
            nextScene.SetActive(true);
        }
    }
    public void SceneChange(){
        SceneManager.LoadScene("SceneWin");
    }
}
