using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5bDialogue : MonoBehaviour
{
    // Start is called before the first frame update
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
    public GameObject ArtChar1a;
    public GameObject ArtChar1b;
    public GameObject ArtChar1c;
    public GameObject ArtCharLose1a;
    public GameObject ArtCharLose1b;
    public GameObject ArtCharLose1c;
    public GameObject ArtChar2a;
    public GameObject ArtChar2b;
    public GameObject ArtChar3a;
    public GameObject ArtChar3b;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject Choice2a;
    public GameObject Choice2b;
    public GameObject nextButton;
    public GameObject nextScene;
    public GameObject nextSceneLose;
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
        ArtChar2b.SetActive(false);
        ArtChar3a.SetActive(false);
        ArtChar3b.SetActive(false);
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
        if (GameHandler.collarColor == 0){
            if (GameHandler.ateTowel == 0){
                ArtChar1Lose = ArtCharLose1a;
            }
            else{
                ArtChar1 = ArtCharLose1c;
            }
        }
        else{
            ArtChar1 = ArtCharLose1b;
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
            ArtChar3a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Wow this band sounds amazing!";
        }
        else if (primeInt == 3){
            ArtChar3a.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "Yea this music sounds great!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 4){
            ArtChar1.SetActive(false);
            ArtChar2b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Frank";
            Char2speech.text = "Would sound a lot better without all your yappin!";
        }
        else if (primeInt == 5){
            ArtChar1Lose.SetActive(true);
            ArtChar2b.SetActive(false);
            Char1name.text = playerName;
            Char1speech.text = "Frank, why do you appear everywhere I go?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 6){
            ArtChar1Lose.SetActive(false);
            ArtChar2b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Frank";
            Char2speech.text = "Hey you’re on my turf! I’m surprised you haven’t gotten dragged back home already!";
        }
        else if (primeInt == 7){
            ArtChar1Lose.SetActive(true);
            ArtChar2b.SetActive(false);
            Char1name.text = playerName;
            Char1speech.text = "{Don’t let him get to you…}";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 8){
            DialogueDisplay.SetActive(false);
            nextButton.SetActive(false);
            Choice1a.SetActive(true);
            Choice1b.SetActive(true);
        }
        else if (primeInt == 11){
            ArtChar1.SetActive(false);
            ArtChar3a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Wow, the band is really getting into it!";
        }
        else if (primeInt == 12){
            ArtChar3a.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "Yea, I’m really feeling the music!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 13){
            ArtChar1.SetActive(false);
            ArtChar3a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Look now they’re dancing!";
        }
        else if (primeInt == 14){
            ArtChar3a.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "Oh wow that looks fun, I wanna dance too! Hmm, but I wanna be closer to the music… maybe I should go up on stage…";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 15){
            DialogueDisplay.SetActive(false);
            nextButton.SetActive(false);
            Choice2a.SetActive(true);
            Choice2b.SetActive(true);
        }
        else if (primeInt == 21){
            ArtChar1.SetActive(true);
            ArtChar3b.SetActive(false);
            Char1name.text = playerName;
            Char1speech.text = "Oh yea, look at my moves!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 22){
            ArtChar1.SetActive(false);
            ArtChar3b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "" + playerName + ", please, get down! You’re messing up the performance!";
        }
        else if (primeInt == 23){
            ArtChar1Lose.SetActive(true);
            ArtChar3b.SetActive(false);
            Char1name.text = playerName;
            Char1speech.text = "Oops! Sorry, I just really wanted to dance.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 24){
            ArtChar1Lose.SetActive(false);
            ArtChar3b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            if (GameHandler.patience <= -4)
            {
                Char3speech.text = "What has gotten into you today, " + playerName + "? I think we should just go home until you behave.";
                nextButton.SetActive(false);
                nextSceneLose.SetActive(true);
            }
            else
            {
                Char3speech.text = "I know you just wanted to dance buddy. Are you ready to head to the lake?";
            }
        }
        else if (primeInt == 25){
            ArtChar1.SetActive(true);
            ArtChar3b.SetActive(false);
            Char1name.text = "Ooo yea! Let's go!!";
            Char1speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            nextButton.SetActive(false);
            nextScene.SetActive(true);
        }
        else if (primeInt == 31){
            ArtChar1.SetActive(false);
            ArtChar3a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Cmon, " + playerName + ", let’s dance!";
        }
        else if (primeInt == 32){
            ArtChar3a.SetActive(true);
            ArtChar1.SetActive(false);
            Char1name.text = playerName;
            Char1speech.text = "Oh yea, look at my moves!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 33){
            ArtChar3a.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Whew, dancing is tiring! Let’s head over to the lake " + playerName + ", it’s hot out here we should cool down a bit.";
        }
        else if (primeInt == 34){
            ArtChar3a.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "Ooo yes! I can’t wait to splash around!";
            Char3name.text = "";
            Char3speech.text = "";
            nextButton.SetActive(false);
            nextScene.SetActive(true);
        }
    }
    public void Choice1Funct(){
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        ArtChar1Lose.SetActive(false);
        ArtChar1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        DialogueDisplay.SetActive(true);
        nextButton.SetActive(true);
        Char1name.text = playerName;
        Char1speech.text = "I’m ignoring you, Frank.";
        primeInt = 10;
    }
    public void Choice2aFunct(){
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        GameHandler.patience -= 1;
        DialogueDisplay.SetActive(true);
        ArtChar1.SetActive(false);
        Char1name.text = "";
        Char1speech.text = "";
        ArtChar3b.SetActive(true);
        Char3name.text = "Guardian";
        Char3speech.text = "No " + playerName + ", get down! Oh geez!";
        primeInt = 20;
        nextButton.SetActive(true);
    }
    public void Choice2bFunct(){
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        DialogueDisplay.SetActive(true);
        Char1speech.text = "Actually, I think I’ll just dance down here.";
        primeInt = 30;
        nextButton.SetActive(true);
    }
    public void SceneChange1(){
        SceneManager.LoadScene("Scene5c");
    }
    public void SceneChange2(){
        SceneManager.LoadScene("Scene6a");
    }
    public void SceneChangeLose(){
        SceneManager.LoadScene("SceneLose");
    }
}
