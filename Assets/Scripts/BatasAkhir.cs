using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BatasAkhir : MonoBehaviour
{
	private int count =0;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnTriggerEnter2D(Collider2D collision){
		Destroy(collision.gameObject);
		count += 1;
		if(count == 5){
			Destroy(collision.gameObject);
			SceneManager.LoadScene("GameOver");
		}
		
		
	}
}
