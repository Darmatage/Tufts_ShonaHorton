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
    GameObject ArtChar1Lose;
    public GameObject ArtCharLose1a;
    public GameObject ArtCharLose1b;
    public GameObject ArtCharLose1c;
    public GameObject ArtChar1a;
    public GameObject ArtChar1b;
    public GameObject ArtChar1c;
    public GameObject ArtChar2a;
    public GameObject ArtChar3a;
    public GameObject ArtChar3b;
    public GameObject ArtBG1;
    public GameObject nextButton;
    public GameObject nextSceneWin;
    public GameObject nextSceneLose;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject Choice2a;
    public GameObject Choice2b;
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
        ArtCharLose1a.SetActive(false);
        ArtCharLose1b.SetActive(false);
        ArtCharLose1c.SetActive(false);
        ArtChar2a.SetActive(false);
        ArtChar3a.SetActive(false);
        ArtChar3b.SetActive(false);
        ArtBG1.SetActive(true);
        nextSceneWin.SetActive(false);
        nextSceneLose.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
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
        if (GameHandler.collarColor == 0){
            if (GameHandler.ateTowel == 0){
                ArtChar1Lose = ArtCharLose1a;
            }
            else{
                ArtChar1Lose = ArtCharLose1c;
            }
        }
        else{
            ArtChar1Lose = ArtCharLose1b;
        }
        ArtChar1.SetActive(false);
        ArtChar1Lose.SetActive(false);
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
            Char3speech.text = "Woah careful, " + playerName + "! Leave the ducks alone!!";
        }
        else if (primeInt == 4){
            ArtChar3a.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "But they're so cute!!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 5){
            DialogueDisplay.SetActive(false);
            nextButton.SetActive(false);
            Choice1a.SetActive(true);
            Choice1b.SetActive(true);
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
            Char1speech.text = "Oh my goodness!! Hi Ollie!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 13){
            ArtChar3a.SetActive(true);
            ArtChar1.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Oh! Do you wanna share your toy with them, " + playerName + "?";
        }
        else if (primeInt == 14){
            ArtChar3a.SetActive (false);
            ArtChar1.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "Hmm, I'm not sure...";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 15){
            DialogueDisplay.SetActive(false);
            nextButton.SetActive(false);
            Choice2a.SetActive(true);
            Choice2b.SetActive(true);
        }
        else if (primeInt == 40){
            ArtChar3a.SetActive(true);
            ArtChar1.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "You wanna play with your toy, " + playerName + "?";
        }
        else if (primeInt == 41){
            ArtChar1.SetActive(true);
            ArtChar3a.SetActive(false);
            Char1name.text = playerName;
            Char1speech.text = "Yes yes!!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 42){
            ArtChar3a.SetActive(true);
            ArtChar1.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "OK go get it!";
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
            Char3speech.text = "I’m so proud of you, " + playerName + "! We finally made it to the park! You've been such a good dog today!";
        }
        else if (primeInt == 25){
            ArtChar3a.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "I know! I'm so happy we made it!!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 26){
            ArtChar3a.SetActive(true);
            ArtChar1.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Come on, " + playerName + ", let's keep playing!";
        }
        else if (primeInt == 27){
            ArtChar3a.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "Yes, let's do it!";
            Char3name.text = "";
            Char3speech.text = "";
            nextButton.SetActive(false);
            nextSceneWin.SetActive(true);
        }
        else if (primeInt == 31){
            ArtChar1.SetActive(false);
            ArtChar3b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "NO " + playerName + "!! Get back here!!";
        }
        else if (primeInt == 32){
            ArtChar1.SetActive(true);
            ArtChar3b.SetActive(false);
            Char1name.text = playerName;
            Char1speech.text = " I gotta catch the duckies!!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 33){
            ArtChar1.SetActive(false);
            ArtChar3b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Dang it, " + playerName + ", now my pants are wet!";
        }
        else if (primeInt == 34){
            ArtChar1Lose.SetActive(true);
            ArtChar3b.SetActive(false);
            Char1name.text = playerName;
            Char1speech.text = "I'm sorry, I didn't mean to!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 35){
            ArtChar1Lose.SetActive(false);
            ArtChar3b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Now we have to go home so I can change!";

            nextButton.SetActive(false);
            nextSceneLose.SetActive(true);
        }
        else if (primeInt == 50){
            ArtChar2a.SetActive(false);
            ArtChar1Lose.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "NO! It's mine!!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 51){
            ArtChar3b.SetActive(true);
            ArtChar1Lose.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Woah, " + playerName + "! That wasn't nice!";
        }
        else if (primeInt == 52){
            ArtChar3b.SetActive(false);
            ArtChar1Lose.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "I just don't want to share!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 53){
            ArtChar3b.SetActive(true);
            ArtChar1Lose.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "I think we have to go home, you can't snap at other dogs like that!";
            nextButton.SetActive(false);
            nextSceneLose.SetActive(true);
        }
        else if (primeInt == 61){
            ArtChar1.SetActive(false);
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Ollie";
            Char2speech.text = "OK!!!";
            primeInt = 20;
        }
    }
    public void SceneChange1(){
        SceneManager.LoadScene("SceneWin");
    }
    public void SceneChange2(){
        SceneManager.LoadScene("SceneLose");
    }
    public void Choice1aFunct(){
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        DialogueDisplay.SetActive(true);
        nextButton.SetActive(true);
        Char1speech.text = "Come here ducks!!!";
        primeInt = 30;
    }
    public void Choice1bFunct(){
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        DialogueDisplay.SetActive(true);
        nextButton.SetActive(true);
        Char1speech.text = "I better leave them alone, I don't want to scare them. ";
        if (GameHandler.nice == 1){
                primeInt = 10;
            }
            else{
                primeInt = 39;
            }
    }
    public void Choice2aFunct(){
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        ArtChar1.SetActive(false);
        ArtChar2a.SetActive(true);
        DialogueDisplay.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "Ollie";
        Char2speech.text = "I'll get it, I'll get it!";
        nextButton.SetActive(true);
        primeInt = 49;
    }
    public void Choice2bFunct(){
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        DialogueDisplay.SetActive(true);
        Char1speech.text = "Come on Ollie, we can play together!";
        nextButton.SetActive(true);
        primeInt = 60;
    }
}
