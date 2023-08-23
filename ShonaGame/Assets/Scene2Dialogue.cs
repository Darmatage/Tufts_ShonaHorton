using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2Dialogue : MonoBehaviour
{
    public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public Text Char4name;
        public Text Char4speech;
        public GameObject DialogueDisplay;
        GameObject ArtChar1;
        public GameObject ArtChar1a;
        public GameObject ArtChar1b;
        public GameObject ArtChar1c;
        public GameObject ArtChar2a;
        public GameObject ArtChar2b;
        public GameObject ArtChar3a;
        public GameObject ArtChar3b;
        public GameObject ArtChar4a;
        public GameObject ArtChar4b;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice2a;
        public GameObject Choice2b;
        public GameObject nextButton;
        public GameObject nextScene1;
        public GameObject nextScene2;
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
        ArtChar4a.SetActive(false);
        ArtChar4b.SetActive(false);
        ArtBG1.SetActive(true);
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
        ArtChar1.SetActive(false);
        nextButton.SetActive(true);
    }

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
            Char2name.text = "Frank";
            Char2speech.text = "Hey doofus! Out on a walk again I see! Let’s see if you actually make it to the park this time haha!";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 3){
            ArtChar2a.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Oh, hey Frank. I will make it this time!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 4){
            ArtChar1.SetActive(false);
            ArtChar2b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Frank";
            Char2speech.text = "Ha! I doubt it! You always mess something up!";
        }
        else if (primeInt == 5){
            ArtChar2b.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Whatever Frank! I’m not gonna let you get in my head!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 6){
            Char1name.text = "YOU";
            Char1speech.text = "{Ooo a fire hydrant… I kind of want to pee on it… oh but I don’t wanna be stereotypical… but it would be fun…}";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            Choice1a.SetActive(true);
            Choice1b.SetActive(true);
        }
        else if (primeInt == 11){
            ArtChar2b.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "I will not apologize for having fun, Frank.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 12){
            ArtChar3b.SetActive(true);
            ArtChar1.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Ugh, [dog]! You almost peed on my shoe!";
        }
        else if (primeInt == 13){
            ArtChar3b.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Oops…";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 14){
            ArtChar1.SetActive(false);
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Frank";
            Char2speech.text = "Ha you idiot!";
        }
        else if (primeInt == 15){
            ArtChar3a.SetActive(true);
            ArtChar2a.SetActive(false);
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Let’s go, and leave that squirrel alone!";
        }
        else if (primeInt == 16){
            ArtChar1.SetActive(true);
            ArtChar3a.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Frank is the one who needs to leave me alone!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 17){
            ArtChar1.SetActive(false);
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Frank";
            Char2speech.text = "Yea, yea. I’ll see you at the dog park, if you ever make it there!";
        }
        else if (primeInt == 18){
            ArtChar1.SetActive(true);
            ArtChar2a.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "I’ll see you there!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 19){
            Char1speech.text = "Oh, a new dog! Hey! I’ve never seen you around here before.";
        }
        else if (primeInt == 20){
            ArtChar1.SetActive(false);
            ArtChar4a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char4name.text = "New Dog";
            Char4speech.text = "Yea I’m uh… I’m new to the neighborhood… I had a little accident in my old one.";
        }
        else if (primeInt == 21){
            ArtChar1.SetActive(true);
            ArtChar4a.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Oh… ok… what kind of accident!";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 22){
            ArtChar1.SetActive(false);
            ArtChar4b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char4name.text = "New Dog";
            Char4speech.text = "What’s it to you! It’s none of your business anyway!";
        }
        else if (primeInt == 23){
            Char1name.text = "YOU";
            Char1speech.text = "{I don’t know how I feel about this dog…}";
            Char4name.text = "";
            Char4speech.text = "";
            nextButton.SetActive(false);
            Choice2a.SetActive(true);
            Choice2b.SetActive(true);
        }
        else if (primeInt == 51){
            ArtChar1.SetActive(false);
            ArtChar2b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Frank";
            Char2speech.text = "Did you seriously just think about peeing on that fire hydrant?";
        }
        else if (primeInt == 52){
            ArtChar1.SetActive(true);
            ArtChar2b.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "I don’t have to explain myself to you, Frank.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 53){
            ArtChar1.SetActive(false);
            ArtChar2a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Frank";
            Char2speech.text = "Yea, yea. I’ll see you at the dog park, if you ever make it there!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 54){
            ArtChar1.SetActive(true);
            ArtChar2a.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "I’ll see you there!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 55){
            Char1speech.text = "Oh, a new dog! Hey! I’ve never seen you around here before.";
        }
        else if (primeInt == 56){
            ArtChar1.SetActive(false);
            ArtChar4a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char4name.text = "New Dog";
            Char4speech.text = "Yea I’m uh… I’m new to the neighborhood… I had a little accident in my old one.";
        }
        else if (primeInt == 57){
            ArtChar1.SetActive(true);
            ArtChar4a.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Oh… ok… what kind of accident!";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 58){
            ArtChar1.SetActive(false);
            ArtChar4b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char4name.text = "New Dog";
            Char4speech.text = "What’s it to you! It’s none of your business anyway!";
        }
        else if (primeInt == 59){
            Char1name.text = "YOU";
            Char1speech.text = "{I don’t know how I feel about this dog…}";
            Char4name.text = "";
            Char4speech.text = "";
            nextButton.SetActive(false);
            Choice2a.SetActive(true);
            Choice2b.SetActive(true);
        }
        else if (primeInt == 66){
            Char4speech.text = "But uh....";
        }
        else if (primeInt == 67){
            Char4speech.text = "I pooped in the hallway of my mom’s apartment so we had to move…";
        }
        else if (primeInt == 68){
            ArtChar4a.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Oh! Hey look, accidents happen, when you gotta go you gotta go! You can’t dwell on it, you gotta move on.";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 69){
            ArtChar1.SetActive(false);
            ArtChar4a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char4name.text = "New Dog";
            Char4speech.text = "Oh wow! I’ve never thought about it like that! That does make me feel a little better, thank you! Oh, I’m Ollie by the way.";
        }
        else if (primeInt == 70){
            ArtChar4a.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "No problem! I’m [dog]. Welcome to the neighborhood, Ollie!";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 71){
            Char1name.text = "";
            Char1speech.text = "";
            Char4name.text = "Ollie";
            Char4speech.text = "Thanks! Hope to see you again soon!";
            nextButton.SetActive(false);
            if (GameHandler.ateTowel == 0){
                nextScene1.SetActive(true);
            }
            else{
                nextScene2.SetActive(true);
            }
        }
        else if (primeInt == 81){
            ArtChar3b.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Sorry I just don’t like them! Their story was suspicious…";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 82){
            ArtChar1.SetActive(false);
            ArtChar3b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "You’re normally so friendly!";
        }
        else if (primeInt == 83){
            ArtChar1.SetActive(true);
            ArtChar3b.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "They were acting weird!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 84){
            ArtChar1.SetActive(false);
            ArtChar3a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char3name.text = "Guardian";
            Char3speech.text = "Ugh… let’s just try to get to the park.";
            nextButton.SetActive(false);
            if (GameHandler.ateTowel == 0){
                nextScene1.SetActive(true);
            }
            else{
                nextScene2.SetActive(true);
            }
        }
    }
    public void Choice1aFunct(){
        GameHandler.patience -= 0.5;
        ArtChar1.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        ArtChar2b.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "Frank";
        Char2speech.text = "Peeing on a fire hydrant? You are so cliche!";
        primeInt = 10;
        nextButton.SetActive(true);
    }
    public void Choice1bFunct(){
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Char1speech.text = "Dog: Nah, I don’t wanna be cliche.";
        primeInt = 50;
        nextButton.SetActive(true);
    }
    public void Choice2aFunct(){
        ArtChar1.SetActive(false);
        ArtChar4a.SetActive(true);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        Char1name.text = "";
        Char1speech.text = "";
        Char4name.text = "New Dog";
        Char4speech.text = "Sorry, sorry. I didn’t mean to be so aggressive, it’s still a sensitive subject. I’m a little embarrassed…";
        GameHandler.nice = 1;
        primeInt = 65;
        nextButton.SetActive(true);
    }

    public void Choice2bFunct(){
        ArtChar1.SetActive(false);
        ArtChar3b.SetActive(true);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        Char1name.text = "";
        Char1speech.text = "";
        Char3name.text = "Guardian";
        Char3speech.text = "No [dog]! What is with you today?";
        GameHandler.patience -= 1;
        primeInt = 80;
        nextButton.SetActive(true);
    }
    public void SceneChange1(){
        SceneManager.LoadScene("Scene3a");
    }
    public void SceneChange2(){
        SceneManager.LoadScene("Scene3b");
    }
}
