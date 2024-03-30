using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5cDialogue : MonoBehaviour
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
    public GameObject Choice3a;
    public GameObject Choice3b;
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
        Choice3a.SetActive(false);
        Choice3b.SetActive(false);
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
            ArtChar1Lose.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "That’s it Frank, I’ve had it! Come here!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 3){
            ArtChar1Lose.SetActive(false);
            ArtChar2b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Frank";
            Char2speech.text = "Catch me if you can, slowpoke!";
        }
        else if (primeInt == 4){
            ArtChar2b.SetActive(false);
            ArtChar1Lose.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "I’ve had enough of your big mouth!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5){
            DialogueDisplay.SetActive(false);
            Choice1a.SetActive(true);
            Choice1b.SetActive(true);
            nextButton.SetActive(false);
        }
        else if (primeInt == 11){
            ArtChar1Lose.SetActive(false);
            ArtChar2b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Frank";
            Char2speech.text = "Please, I could run circles around you!";
        }
        else if (primeInt == 12){
            ArtChar2b.SetActive(false);
            ArtChar1Lose.SetActive(true);
            DialogueDisplay.SetActive(false);
            Choice2a.SetActive(true);
            Choice2b.SetActive(true);
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
        }
        else if (primeInt == 16){
            ArtChar1Lose.SetActive(false);
            ArtChar2b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Frank";
            Char2speech.text = "Eat my dust, Doofus!";
        }
        else if (primeInt == 17){
            ArtChar2b.SetActive(false);
            ArtChar1Lose.SetActive(true);
            Char2name.text = "";
            Char2speech.text = "";
            DialogueDisplay.SetActive(false);
            Choice3a.SetActive(true);
            Choice3b.SetActive(true);
            nextButton.SetActive(false);
        }
        else if (primeInt == 21){
            ArtChar1Lose.SetActive(false);
            ArtChar1.SetActive(true);
            Char1speech.text = "But wait… what’s that smell?";
        }
        else if (primeInt == 22){
            Char1speech.text = "It smells like… hot dogs!";
            nextButton.SetActive(false);
            nextScene.SetActive(true);
        }
    }
    public void Choice1Funct(){
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        DialogueDisplay.SetActive(true);
        Char1name.text = playerName;
        Char1speech.text = "I’m tired of you making fun of me Frank, I’m gonna get you!";
        primeInt = 10;
        nextButton.SetActive(true);
    }
    public void Choice2Funct(){
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        DialogueDisplay.SetActive(true);
        Char1name.text = playerName;
        Char1speech.text = "Get back here, Frank!";
        primeInt = 15;
        nextButton.SetActive(true);
    }
    public void Choice3Funct(){
        Choice3a.SetActive(false);
        Choice3b.SetActive(false);
        DialogueDisplay.SetActive(true);
        Char1name.text = playerName;
        Char1speech.text = "Uh oh… I think I’m lost! I don’t see my guardian anywhere!";
        primeInt = 20;
        nextButton.SetActive(true);
    }
    public void SceneChange(){
        SceneManager.LoadScene("Scene6b");
    }
}
