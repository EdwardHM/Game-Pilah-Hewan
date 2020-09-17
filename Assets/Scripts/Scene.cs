using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class Scene : MonoBehaviour {
 
   // pindah scene ke menu
   public void MenuScene() {
       SceneManager.LoadScene("Home");
   }
 
   // pindah scene ke loading
   public void LoadingScene() {
       SceneManager.LoadScene("Loading");
   }
   
    // Start is called before the first frame update
    void Start()
    {
        
    }
	  // Update is called once per frame
	void Update()
    {
		if (Input.GetKeyUp(KeyCode.Escape)){
			SceneManager.LoadScene("Keluar");
		}
    }
 
   // keluar dari game
   public void KeluarScene() {
      Application.Quit();
   }
}