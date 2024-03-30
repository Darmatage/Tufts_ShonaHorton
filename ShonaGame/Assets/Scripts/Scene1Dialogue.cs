using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class Scene1Dialogue : MonoBehaviour {
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
        public GameObject ArtChar1c;
        public GameObject ArtChar2a;
        public GameObject ArtChar2b;
        public GameObject ArtChar3;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice2a;
        public GameObject Choice2b;
        public GameObject Collar1;
        public GameObject Collar2;
        public GameObject nextButton;
        public GameObject nextScene;
        public string playerName;
        public GameHandler gameHandler;
       //public AudioSource audioSource;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        string pNameTemp = gameHandler.GetName();
        playerName = pNameTemp;
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(false);
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(false);
        ArtChar3.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        Collar1.SetActive(false);
        Collar2.SetActive(false);
        nextScene.SetActive(false);
        nextButton.SetActive(true);
   }


//Story Units! The main story function. Players hit [NEXT] to progress to the next primeInt:
public void Next(){
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = playerName;
                Char1speech.text = "Felix! Felix! Guess what?! ";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                ArtChar1a.SetActive(false);
                ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Felix";
                Char2speech.text = "Oh geez, what do you want? I’ve already seen you chase your tail three times today, it’s gotten pretty old. ";
        }
       else if (primeInt == 4){
                ArtChar1a.SetActive(true);
                ArtChar2a.SetActive(false);
                Char1name.text = playerName;
                Char1speech.text = "No not that! Our guardian and I are going to the dog park! ";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                ArtChar1a.SetActive(false);
                ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Felix";
                Char2speech.text =  "And so it begins. Do you think you’ll actually make it to the park this time? ";
        }
       else if (primeInt == 6){
                ArtChar1a.SetActive(true);
                ArtChar2a.SetActive(false);
                Char1name.text = playerName;
                Char1speech.text = "Huh? What are you talking about? ";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                ArtChar1a.SetActive(false);
                ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Felix";
                Char2speech.text = "Almost every time you try to go to the park, something happens that freaks our poor guardian out and you come home early. ";
        }
       else if (primeInt == 8){
                ArtChar1a.SetActive(true);
                ArtChar2a.SetActive(false);
                Char1name.text = playerName;
                Char1speech.text =  "What? That’s not true! ";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 9){
                ArtChar1a.SetActive(false);
                ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Felix";
                Char2speech.text = "Oh it’s true, you haven’t been to the park in a week and a half. I know because that was the last time I got any peace in this house. ";
        }
        else if (primeInt == 10){
                ArtChar1a.SetActive(true);
                ArtChar2a.SetActive(false);
                Char1name.text = playerName;
                Char1speech.text =  "Oh… I guess you’re right. But today I’m gonna make it to the park! Nothing will get in my way! ";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 11){
                ArtChar1a.SetActive(false);
                ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Felix";
                Char2speech.text =  "Boy I hope so, I could really use the peace and quiet. ";
        }
        else if (primeInt == 12){
                ArtChar1a.SetActive(true);
                ArtChar2a.SetActive(false);
                Char1name.text = playerName;
                Char1speech.text = "Wait do you smell that… it smells like… a used paper towel!! I see it, it’s on the floor in the kitchen! ";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 13){
                ArtChar1a.SetActive(false);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Felix";
                Char2speech.text = "You’re going to eat it, aren’t you? ";
        }
        else if (primeInt == 14){
                ArtChar1a.SetActive(true);
                ArtChar2b.SetActive(false);
                Char1name.text = playerName;
                Char1speech.text = "…Maybe… ";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 15){
                ArtChar1a.SetActive(false);
                ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Felix";
                Char2speech.text = "I’ll never understand why you do that. ";
                // Turn off "Next" button, turn on "Choice" buttons
        }
        else if (primeInt == 16){
                ArtChar2b.SetActive(false);
                ArtChar1a.SetActive(true);
                nextButton.SetActive(false);
                DialogueDisplay.SetActive(false);
                Choice1a.SetActive(true);
                Choice1b.SetActive(true);
        }
        

       

       // after choice 1b
       else if (primeInt == 20){
                ArtChar1a.SetActive(false);
                ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "Guardian";
                Char3speech.text = "OK, " + playerName + "! What color collar do you want to wear today? ";
        }
       else if (primeInt == 21){
                ArtChar1a.SetActive(true);
                ArtChar3.SetActive(false);
                Char1name.text = playerName;
                Char1speech.text = "Ooh! Felix, what color collar should I choose? ";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 22){
                ArtChar1a.SetActive(false);
                ArtChar2b.SetActive(false);
                ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Felix";
                Char2speech.text = "Whichever one gets you out of the house faster. ";
        }
        else if (primeInt == 23){
                ArtChar2a.SetActive(false);
                Choice2a.SetActive(true);
                Choice2b.SetActive(true);
                Collar1.SetActive(true);
                Collar2.SetActive(true);
                DialogueDisplay.SetActive(false);
                nextButton.SetActive(false);
        }
        else if (primeInt == 30){
                ArtChar1b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                ArtChar3.SetActive(true);
                Char3name.text = "Guardian";
                Char3speech.text = "Oh! Can’t forget your toy. ";
        }
        else if (primeInt == 31){
                ArtChar1b.SetActive(true);
                ArtChar3.SetActive(false);
                Char1name.text = playerName;
                Char1speech.text = "Alright Felix, we’re off to the park! ";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 32){
                ArtChar1b .SetActive(false);
                ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Felix";
                Char2speech.text = "Thank goodness, now I can finally nap. ";
                nextButton.SetActive(false);
                nextScene.SetActive(true);
        }
        else if (primeInt == 36){
                ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                ArtChar3.SetActive(true);
                Char3name.text = "Guardian";
                Char3speech.text = "Oh! Can’t forget your toy. ";
        }
        else if (primeInt == 37){
                ArtChar1c.SetActive(true);
                ArtChar3.SetActive(false);
                Char1name.text = playerName;
                Char1speech.text = "Alright Felix, we’re off to the park! ";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 38){
                ArtChar1c .SetActive(false);
                ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Felix";
                Char2speech.text = "Thank goodness, now I can finally nap. ";
                nextButton.SetActive(false);
                nextScene.SetActive(true);
        }



      //Please do NOT delete this final bracket that ends the Next() function:
     
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1bFunct(){
                DialogueDisplay.SetActive(true);
                Char1name.text = playerName;
                Char1speech.text = "Oh yuck it was used to clean ketchup! I hate ketchup. ";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
        }

        public void Choice2aFunct(){
                DialogueDisplay.SetActive(true);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                ArtChar2a.SetActive(false);
                Collar1.SetActive(false);
                Collar2.SetActive(false);
                Char2name.text = "";
                Char2speech.text = "";
                Char1name.text = playerName;
                Char1speech.text = "Lookin’ pretty good if I do say so myself! ";
                primeInt = 29;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
        }
        public void Choice2bFunct(){
                DialogueDisplay.SetActive(true);
                GameHandler.collarColor = 1;
                ArtChar1a.SetActive(false);
                ArtChar1c.SetActive(true);
                ArtChar2a.SetActive(false);
                Collar1.SetActive(false);
                Collar2.SetActive(false);
                Char2name.text = "";
                Char2speech.text = "";
                Char1name.text = playerName;
                Char1speech.text = "Lookin’ pretty good if I do say so myself! ";
                primeInt = 35;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene1b");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2");
        }

}