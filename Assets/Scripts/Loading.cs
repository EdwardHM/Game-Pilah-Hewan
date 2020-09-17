using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class Loading : MonoBehaviour {
 
   // waktu delay untuk load scene
   [SerializeField] private float delayLoading = 3f;
   
//nama scene untuk pindah scene yang diinputkan di inspector
   [SerializeField] private string namaScene;
 
    private float timeElapsed;
     // Update is called once per frame
    private void Update () {
        timeElapsed += Time.deltaTime;
        
        if (timeElapsed > delayLoading) 
		{
            SceneManager.LoadScene(namaScene);
        }
    }
}

