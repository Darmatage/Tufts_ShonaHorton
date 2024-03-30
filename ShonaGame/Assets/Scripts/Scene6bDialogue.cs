using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene6bDialogue : MonoBehaviour
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
        ArtCharLose1a.SetActive(false);
        ArtCharLose1b.SetActive(false);
        ArtCharLose1c.SetActive(false);
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
            ArtChar1Lose.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "Ooo hot dogs! I hope my guardian will get me one… whenever I find them.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 3){
            ArtChar1Lose.SetActive(false);
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Frank";
            Char2speech.text = "Ha ha, you couldn’t catch me, loser!!";
        }
        else if (primeInt == 4){
            ArtChar1Lose.SetActive(true);
            ArtChar2a.SetActive(false);
            Char1name.text = playerName;
            Char1speech.text = "I’ve had enough of you, Frank! I-";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5){
            ArtChar1Lose.SetActive(false);
            ArtChar3a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = playerName.ToUpper() + "!!! There you are! I’ve been looking all over for you!";
        }
        else if (primeInt == 6){
            ArtChar1.SetActive(true);
            ArtChar3a.SetActive(false);
            Char1name.text = playerName;
            Char1speech.text = "Oh there you are! Can I have a hot dog?";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 7){
            ArtChar1.SetActive(false);
            ArtChar3a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "I hope you don’t think you’re getting any treats!";
        }
        else if (primeInt == 8){
            ArtChar1Lose.SetActive(true);
            ArtChar3a.SetActive(false);
            Char1name.text = playerName;
            Char1speech.text = "…well I was hoping…";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 9){
            ArtChar1Lose.SetActive(false);
            ArtChar3a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "You’ve been so bad today! And now you’re running off?!";
        }
        else if (primeInt == 10){
            ArtChar1Lose.SetActive(true);
            ArtChar3a.SetActive(false);
            Char1name.text = playerName;
            Char1speech.text = "It was Frank! He-";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 11){
            ArtChar1Lose.SetActive(false);
            ArtChar3a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "That’s it! You’ve been acting out way too much today! We’re going home!";
            nextButton.SetActive(false);
            nextScene.SetActive(true);
        }
    }
    public void SceneChange(){
        SceneManager.LoadScene("SceneLose");
    }
}
