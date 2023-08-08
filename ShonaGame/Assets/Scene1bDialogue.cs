using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1bDialogue : MonoBehaviour
{
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
        public GameObject ArtChar1b;
        public GameObject ArtChar2a;
        public GameObject ArtChar2b;
        public GameObject ArtChar3a;
        public GameObject ArtChar3b;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject nextButton;
        public GameObject nextScene;
    // Start is called before the first frame update
    void Start()
    {
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(false);
        ArtChar3a.SetActive(false);
        ArtChar3b.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextScene.SetActive(false);
        nextButton.SetActive(true);
    }

    // Update is called once per frame
    public void Next()
    {
        primeInt = primeInt + 1;
        if (primeInt == 1){

        }
        else if (primeInt == 2)
        {
            DialogueDisplay.SetActive(true);
            ArtChar1a.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = " Oooohhh… it smells reeeeaaally good.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 2){
            ArtChar1a.SetActive(false);
            ArtChar2b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Felix";
            Char2speech.text = "Think this through, [dog].";
        }
        else if (primeInt == 3){
            ArtChar1a.SetActive(true);
            ArtChar2b.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Maybe our guardian won’t mind if I just taste it?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 4){
            ArtChar1a.SetActive(false);
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Felix";
            Char2speech.text = "When have you ever “just tasted” anything?";
        }
        else if (primeInt == 5){
            ArtChar1a.SetActive(true);
            ArtChar2a.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Maybe just a lick. A lick and a sniff. A lick, a sniff and a “CHOMP”";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 6){
            ArtChar1a.SetActive(false);
            ArtChar3b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "[Dog] what are you doing! Drop that!";
        }
        else if (primeInt == 7){
            ArtChar3b.SetActive(false);
            ArtChar2b.SetActive(true);
            Char2name.text = "Felix";
            Char2speech.text = "Now you’ve done it.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 8){
            ArtChar1a.SetActive(true);
            ArtChar2b.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "*muffled* Muh Mo";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 9){
            ArtChar1a.SetActive(false);
            ArtChar3b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "[Dog], drop that right now!";
            nextButton.SetActive(false);
            Choice1a.SetActive(true);
            Choice1b.SetActive(true);
        }
        else if (primeInt == 16){
            ArtChar3a.SetActive(false);
            ArtChar1a.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "I AM a good dog. Does that mean I can eat the towel now?";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 17){
            ArtChar1a.SetActive(false);
            ArtChar3a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Ready to go for a walk?";
        }
        else if (primeInt == 18){
            ArtChar1a.SetActive(true);
            ArtChar3a.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Yes please!";
            Char3name.text = "";
            Char3speech.text = "";
            nextButton.SetActive(true);
        }
        else if (primeInt == 19){
            ArtChar1a.SetActive(false);
            ArtChar3a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Oh! Can't forget your toy!";
            nextButton.SetActive(false);
            nextScene.SetActive(true);
        }
        else if (primeInt == 26){
            ArtChar3b.SetActive(false);
            ArtChar1a.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "But itch ish sho yummy!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 27){
            ArtChar1a.SetActive(false);
            ArtChar3a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Ugh! I got it! You are trying my patience!";
        }
        else if (primeInt == 28){
            ArtChar3a.SetActive(false);
            ArtChar1b.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "I’m sorry. I will be a good dog.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 29){
            ArtChar1b.SetActive(false);
            ArtChar3a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Oh, well. Let’s go for our walk.";
            nextButton.SetActive(false);
            nextScene.SetActive(true);
        }
    }
    public void Choice1aFunct(){
        ArtChar3b.SetActive(false);
        ArtChar3a.SetActive(true);
        Char3speech.text = "Good dog, [Dog].";
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        primeInt = 15;
        nextButton.SetActive(true);
    }
    public void Choice1bFunct(){
        GameHandler.ateTowel = true;
        GameHandler.patience -= 1;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Char3speech.text = "Give me that, [Dog]!";
        primeInt = 25;
        nextButton.SetActive(true);
    }
    public void SceneChange1(){
        SceneManager.LoadScene("Scene2");
    }
}
