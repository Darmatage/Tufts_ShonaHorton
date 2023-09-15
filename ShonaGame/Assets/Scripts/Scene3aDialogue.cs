using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3aDialogue : MonoBehaviour
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
    public GameObject ArtChar2b;
    public GameObject ArtChar3a;
    public GameObject ArtChar3b;
    public GameObject Bacon;
    public GameObject Pumpkin;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject Choice2a;
    public GameObject Choice2b;
    public GameObject nextButton;
    public GameObject nextScene;
    public GameObject nextSceneLose;
    // Start is called before the first frame update
    void Start()
    {
        DialogueDisplay.SetActive(false); 
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(false);
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(false);
        ArtChar3a.SetActive(false);
        ArtChar3b.SetActive(false);
        Bacon.SetActive(false);
        Pumpkin.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextScene.SetActive(false);
        nextSceneLose.SetActive(false);
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
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Plunky";
            Char2speech.text = "Hiya [dog]! Hiya [dog]! Whatcha doing? Whatcha doing?";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 3){
            ArtChar2a.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Oh hi Plunky! We’re going to the park!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 4){
            ArtChar1.SetActive(false);
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Plunky";
            Char2speech.text = "Sure you are! Sure you are! Hey now, hey now. Can you get me out of my cage out of my cage?";
        }
        else if (primeInt == 5){
            ArtChar1.SetActive(true);
            ArtChar2a.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "I don’t think my guardian would like that…";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 6){
            ArtChar2a.SetActive(true);
            ArtChar1.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Plunky";
            Char2speech.text = "Worth a shot, worth a shot.";
        }
        else if (primeInt == 7){
            ArtChar2a.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Ooo Plunky which treat do you think I should get? The bacon one is always good, but they have a pumpkin one that I’ve never tried! Hmmm…";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 8){
            ArtChar2a.SetActive(true);
            ArtChar1.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Plunky";
            Char2speech.text = "Get the cracker! Get the cracker!";
        }
        else if (primeInt == 9){
            ArtChar2a.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Uh Plunky… they don’t have crackers here…";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 10){
            ArtChar1.SetActive(false);
            ArtChar2b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Plunky";
            Char2speech.text = "Boo! Boo!";
        }
        else if (primeInt == 11){
            Char2name.text = "";
            Char2speech.text = "";
            ArtChar2b.SetActive(false);
            DialogueDisplay.SetActive(false);
            Bacon.SetActive(true);
            Pumpkin.SetActive(true);
            Choice1a.SetActive(true);
            Choice1b.SetActive(true);
            nextButton.SetActive(false);
        }
        else if (primeInt == 16){
            ArtChar1.SetActive(false);
            ArtChar3a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Alright [dog], ready to go?";
        }
        else if (primeInt == 17){
            ArtChar1.SetActive(true);
            ArtChar3a.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Yup, I’m ready! *sniff* wait… *sniff sniff* Plunky do you smell that?";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 18){
            ArtChar2a.SetActive(true);
            ArtChar1.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Plunky";
            Char2speech.text = "Peanut butter, peanut butter!";
        }
        else if (primeInt == 19){
            ArtChar2a.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "That guy got the last peanut butter flavor bomb! Ooo and peanut butter’s my favorite!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 20){
            Char1speech.text = "Smells so good, and it’s right there! Maybe he won’t mind if I just take a little nibble…";
            nextButton.SetActive(false);
            Choice2a.SetActive(true);
            Choice2b.SetActive(true);
        }
        else if (primeInt == 26){
            ArtChar1.SetActive(true);
            ArtChar3b.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Mmmm peanut butter… so good…";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 27){
            ArtChar1.SetActive(false);
            ArtChar3b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Ugh I can’t believe you! Let’s get out of here before you embarrass me anymore than you already have!";
            nextButton.SetActive(false);
            if (GameHandler.patience <= -4){
                nextSceneLose.SetActive(true);
            }
            else {
                nextScene.SetActive(true);
            }
        }
        else if (primeInt == 31){
            ArtChar3a.SetActive(true);
            ArtChar1.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Come on, [dog], let's get to the park!";
        }
        else if (primeInt == 32){
            ArtChar1.SetActive(true);
            ArtChar3a.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Yes let’s go!!";
            Char3name.text = "";
            Char3speech.text = "";
            nextButton.SetActive(false);
            nextScene.SetActive(true);
        }
    }
    public void Choice1aFunct(){
        DialogueDisplay.SetActive(true);
        ArtChar1.SetActive(true);
        Bacon.SetActive(false);
        Pumpkin.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        primeInt = 15;
        Char1name.text = "YOU";
        Char1speech.text = "Can't go wrong with bacon!";
    }
    public void Choice1bFunct(){
        DialogueDisplay.SetActive(true);
        ArtChar1.SetActive(true);
        Bacon.SetActive(false);
        Pumpkin.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        primeInt = 15;
        Char1name.text = "YOU";
        Char1speech.text = "I'm feeling adventurous, lets go with pumpkin!";
    }
    public void Choice2aFunct(){
        GameHandler.patience -= 1.5;
        ArtChar1.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        ArtChar3b.SetActive(true);
        primeInt = 25;
        Char1name.text = "";
        Char1speech.text = "";
        Char3name.text = "Guardian";
        Char3speech.text = "No [dog], drop it! I literally just bought you some treats!!";
        nextButton.SetActive(true);
    }
    public void Choice2bFunct(){
        GameHandler.patience += 2;
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        primeInt = 30;
        Char1speech.text = "No I can’t! I can’t take that peanut buttery deliciousness away from someone else, that wouldn’t be right!";
        nextButton.SetActive(true);
    }
    public void SceneChangeLose(){
        SceneManager.LoadScene("SceneLose");
    }
    public void SceneChange(){
        SceneManager.LoadScene("Scene4");
    }
}
