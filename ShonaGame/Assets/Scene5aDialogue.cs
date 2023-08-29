using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5aDialogue : MonoBehaviour
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
    public GameObject nextScene2;
    public GameObject nextSceneLose;
    // Start is called before the first frame update
    void Start()
    {
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
        nextScene2.SetActive(false);
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
            ArtChar3a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Ah, it’s nice out here isn’t it [dog]?";
        }
        else if (primeInt == 3){
            ArtChar1.SetActive(true);
            ArtChar3a.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "It sure is!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 4){
            ArtChar1.SetActive(false);
            ArtChar2b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Frank";
            Char2speech.text = "It would be nicer without you here.";
        }
        else if (primeInt == 5){
            ArtChar2b.SetActive(false);
            ArtChar1Lose.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Go away, Frank.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 6){
            ArtChar1Lose.SetActive(false);
            ArtChar2b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Frank";
            Char2speech.text = "I’m shocked you haven’t gotten dragged back home already!";
        }
        else if (primeInt == 7){
            ArtChar2b.SetActive(false);
            ArtChar1Lose.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "{Don’t let him get to you…}";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 8){
            Char1name.text = "";
            Char1speech.text = "";
            DialogueDisplay.SetActive(false);
            Choice1a.SetActive(true);
            Choice1b.SetActive(true);
            nextButton.SetActive(false);
        }
    }
}
