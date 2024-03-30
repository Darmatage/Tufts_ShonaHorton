using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4Dialogue : MonoBehaviour
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
    public GameObject nextButton;
    public GameObject nextScene1;
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
        nextScene1.SetActive(false);
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
            ArtChar1.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "I made it, I made it!! Now I can enjoy the park!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 3){
            ArtChar1.SetActive(false);
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Frank";
            Char2speech.text = "Well look who finally showed up! I’m surprised to see you here, Doofus.";
        }
        else if (primeInt == 4){
            ArtChar1Lose.SetActive(true);
            ArtChar2a.SetActive(false);
            Char1name.text = playerName;
            Char1speech.text = "{Ugh it’s Frank}";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5){
            Char1speech.text = "I told you I’d make it Frank!";
        }
        else if (primeInt == 6){
            ArtChar1Lose.SetActive(false);
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Frank";
            Char2speech.text = "You just haven’t been here in so long I didn’t think you’d remember the way!";
        }
        else if (primeInt == 7){
            ArtChar1Lose.SetActive(true);
            ArtChar2a.SetActive(false);
            Char1name.text = playerName;
            Char1speech.text = "You know Frank, I’m getting really tired of you making fun of me all the time.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 8){
            ArtChar2b.SetActive(true);
            ArtChar1Lose.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Frank";
            Char2speech.text = "Oh yea? Well what are you gonna do about it huh? You’re not gonna do anything!";
        }
        else if (primeInt == 9){
            ArtChar2b.SetActive(false);
            ArtChar1Lose.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "{Maybe I should finally teach Frank a lesson…}";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            Choice1a.SetActive(true);
            Choice1b.SetActive(true);
        }
        else if (primeInt == 12){
            ArtChar1.SetActive(false);
            ArtChar2b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Frank";
            Char2speech.text = "Whatever man!";
        }
        else if (primeInt == 13){
            ArtChar2b.SetActive(false);
            ArtChar3a.SetActive(true);
            Char1name.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Ok, " + playerName + " do you want to go down our usual path? Or do you want to go down this way, I think I hear music coming from there.";
        }
        else if (primeInt == 14){
            DialogueDisplay.SetActive(false);
            nextButton.SetActive(false);
            Choice2a.SetActive(true);
            Choice2b.SetActive(true);
        }
    }
    public void Choice1aFunct(){
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Char1speech.text = "That’s it Frank, I’ve had it! Come here!";
        nextScene1.SetActive(true);
    }
    public void Choice1bFunct(){
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        ArtChar1Lose.SetActive(false);
        ArtChar1.SetActive(true);
        Char1speech.text = "You know what Frank, you’re not even worth my time! Why don’t you go bother someone else?";
        primeInt = 11;
        nextButton.SetActive(true);
    }
    public void SceneChange1(){
        SceneManager.LoadScene("Scene5c");
    }
    public void SceneChange2(){
        SceneManager.LoadScene("Scene5a");
    }
    public void SceneChange3(){
        SceneManager.LoadScene("Scene5b");
    }
}
