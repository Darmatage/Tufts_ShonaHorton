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
        public GameObject Harness1;
        public GameObject Harness2;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
        public GameObject menuButton;
       //public AudioSource audioSource;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        Harness1.SetActive(false);
        Harness2.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
        menuButton.SetActive(false);
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
                Char1name.text = "YOU";
                Char1speech.text = "Felix! Felix! Guess what?!";
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
                Char2speech.text = "Oh geez, what do you want? I’ve already seen you chase your tail three times today, it’s gotten pretty old.";
        }
       else if (primeInt == 4){
                ArtChar1a.SetActive(true);
                ArtChar2a.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "No not that! Our guardian and I are going to the dog park!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                ArtChar1a.SetActive(false);
                ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Felix";
                Char2speech.text = "And so it begins. Do you think you’ll actually make it to the park this time?";
        }
       else if (primeInt == 6){
                ArtChar1a.SetActive(true);
                ArtChar2a.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Huh? What are you talking about?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                ArtChar1a.SetActive(false);
                ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Felix";
                Char2speech.text = "Almost every time you try to go to the park, something happens that freaks our poor guardian out and you come home early.";
        }
       else if (primeInt == 8){
                ArtChar1a.SetActive(true);
                ArtChar2a.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "What? That’s not true!";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 9){
                ArtChar1a.SetActive(false);
                ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Felix";
                Char2speech.text = "Oh it’s true, you haven’t been to the park in a week and a half. I know because that was the last time I got any peace in this house.";
        }
        else if (primeInt == 10){
                ArtChar1a.SetActive(true);
                ArtChar2a.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Oh… I guess you’re right. But today I’m gonna make it to the park! Nothing will get in my way!";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 11){
                ArtChar1a.SetActive(false);
                ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Felix";
                Char2speech.text = "Boy I hope so, I could really use the peace and quiet.";
        }
        else if (primeInt == 12){
                ArtChar1a.SetActive(true);
                ArtChar2a.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Wait do you smell that… it smells like… a used paper towel!! I see it, it’s on the floor in the kitchen!";
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
                Char2speech.text = "You’re going to eat it, aren’t you?";
        }
        else if (primeInt == 14){
                ArtChar1a.SetActive(true);
                ArtChar2b.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "… Maybe…";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 15){
                ArtChar1a.SetActive(false);
                ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Felix";
                Char2speech.text = "I’ll never understand why you do that.";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                //Choice1a.SetActive(true);
                NextScene1Button.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
        

       

       // after choice 1b
       else if (primeInt == 20){
                ArtChar1a.SetActive(false);
                ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "Guardian";
                Char3speech.text = "OK, [dog]! What color harness do you want to wear today?";
        }
       else if (primeInt == 21){
                ArtChar1a.SetActive(true);
                ArtChar3.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Ooh! Felix, what color harness should I choose?";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 22){
                ArtChar1a.SetActive(false);
                ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Felix";
                Char2speech.text = "Whichever one gets you out of the house faster.";
                Choice2a.SetActive(true);
                Choice2b.SetActive(true);
        }


      //Please do NOT delete this final bracket that ends the Next() function:
     
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1bFunct(){
                ArtChar1a.SetActive(true);
                ArtChar2a.SetActive(false);
                NextScene1Button.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Oh yuck it was used to clean ketchup! I hate ketchup.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
        }

        public void Choice2aFunct(){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
        }


        public void SceneChange1(){
               SceneManager.LoadScene("Scene1b");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene1c");
        }
}