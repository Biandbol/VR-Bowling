using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Text = TMPro.TextMeshProUGUI;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
{

    public int score = 0;
    public Text scoreText;
    public Text congrats;
    respawn respawn;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("pin"))
        {
            score++;
            Debug.Log(score);
            UpdateScoreUI();
            
            
        }
        if(score==10 ) {
            congrats.gameObject.SetActive(true);
            respawn.over.SetActive(false);

            
        
        
        
        
        }
    }
    public void replay()
    {
        scoreText.text = "Score: ";
        SceneManager.LoadScene(0);


    }
    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score.ToString(); 
    }
}
