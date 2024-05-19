using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class NameTransfer : MonoBehaviour {

        public string theName;
        public GameObject inputField;
        public GameObject textDisplay;
        public GameObject textDisplayBG;
        public GameHandler gameHandler;
        public GameObject welcomeDisplay;


        void Start () {
                if (GameHandler.playerName == "YOU"){
                        welcomeDisplay.SetActive(false);
                } else {
                        DisplayName(GameHandler.playerName);
                }
                Debug.Log(inputField.GetComponent<Text>());
        }

        public void StoreName(){
                theName = inputField.GetComponentInChildren<Text>().text;
                gameHandler.UpdateName(theName);
                DisplayName(theName);
        }

        public void DisplayName(string theName){
                textDisplay.GetComponent<Text>().text = "Welcome, " + theName + ", to the game.";
                textDisplayBG.GetComponent<Text>().text = "Welcome, " + theName + ", to the game.";
                welcomeDisplay.SetActive(true);
        }
}