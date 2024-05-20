using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameHandler : MonoBehaviour{

        public static int collarColor = 0;
        public static int ateTowel = 0;
        public static double patience = 3;
        public static int nice = 0;
        public static string playerName = "YOU";
        

        public static bool GameisPaused = false;
        public GameObject pauseMenuUI;
        public AudioMixer mixer;
        public static float volumeLevel = 1.0f;
        private Slider sliderVolumeCtrl;
        // public GameObject textGameObject;

        void Awake(){
                SetLevel(volumeLevel);
                GameObject sliderTemp = GameObject.FindWithTag("PauseMenuSlider");
                if (sliderTemp != null){
                        sliderVolumeCtrl = sliderTemp.GetComponent<Slider>();
                        sliderVolumeCtrl.value = volumeLevel;
                }
        }

        void Start(){
                pauseMenuUI.SetActive(false);
                GameisPaused = false;
        }

        void Update(){         //delete this quit functionality when a Pause Menu is added!
                if (Input.GetKeyDown(KeyCode.Escape)){
                        if (GameisPaused){Resume();}
                        else{Pause();}
                }
        }

        void Pause(){
                pauseMenuUI.SetActive(true);
                Time.timeScale =0f;
                GameisPaused = true;
        }
        public void Resume(){
                pauseMenuUI.SetActive(false);
                Time.timeScale = 1f;
                GameisPaused = false;
        }

        public void SetLevel(float sliderValue){
                mixer.SetFloat("MusicVolume", Mathf.Log10 (sliderValue) * 20);
                volumeLevel = sliderValue;
        }

        public void StartGame(){
                collarColor = 0;
                ateTowel = 0;
                patience = 3;
                nice = 0;
                SceneManager.LoadScene("Scene1a");
        }

        public void OpenCredits(){
                SceneManager.LoadScene("Credits");
        }

        public void RestartGame(){
                Time.timeScale = 1f;
                SceneManager.LoadScene("MainMenu");
        }

        public void QuitGame(){
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #else
                Application.Quit();
                #endif
        }

        public void UpdateName(string newName){
                playerName = newName;
                Debug.Log("name changed to " + playerName);
        }
        
        public string GetName(){
                return playerName;
        }
}