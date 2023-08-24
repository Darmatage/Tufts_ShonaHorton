using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3bDialogue : MonoBehaviour
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
    public GameObject Bacon;
    public GameObject Pumpkin;
    public GameObject ArtBG1;
    public GameObject ArtBG2;
    public GameObject ArtBG3;
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
        ArtCharLose1a.SetActive(false);
        ArtCharLose1b.SetActive(false);
        ArtCharLose1c.SetActive(false);
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(false);
        ArtChar3a.SetActive(false);
        ArtChar3b.SetActive(false);
        ArtChar4a.SetActive(false);
        ArtChar4b.SetActive(false);
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
        ArtBG3.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextScene1.SetActive(false);
        nextScene2.SetActive(false);
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
            ArtChar3a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Oh geez [dog], I forgot your toy at home! We should probably stop at the pet store to get one.";
        }
        else if (primeInt == 2){
            ArtChar3a.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Ooo yes please!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 3){
            ArtChar1.SetActive(false);
            ArtBG1.SetActive(false);
            ArtBG2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
        }
        else if (primeInt == 4){
            ArtChar2a.SetActive(true);
            Char2name.text = "Bosco";
            Char2speech.text = "Hey kid! Headin’ to the dog park?";
        }
        else if (primeInt == 5){
            ArtChar2a.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Oh hey Bosco! Yea, we’re stopping to get a toy first.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 6){
            ArtChar2a.SetActive(true);
            ArtChar1.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Bosco";
            Char2speech.text = "Nice! You think you’ll actually make it to the park this time around?";
        }
        else if (primeInt == 7){
            ArtChar2a.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Why does everyone keep saying that?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 8){
            ArtChar2a.SetActive(true);
            ArtChar1.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Bosco";
            Char2speech.text = "Relax, I’m just pulling your tail. Which toy are you thinking about getting?";
        }
    }
}
