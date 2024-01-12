using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets = new List<GameObject>();
    private float spawnRate = 1.0f;
    private int score;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverText;
    public bool isGameActive;
    public GameObject titleScreen;
    // Start is called before the first frame update
    void Start()
    {
        

       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnTarget() {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate); 
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
            

        }

       
    
    
    
    
    }
    public void UpdateScore(int scoreToAdd) 
    {
        score += scoreToAdd;
        scoreText.text = "score: " + score;
    }
    public void GameOver() 
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive=false;
    }
    public void RestartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame(int difficulty) 
    {
        isGameActive = true;
        score = 0;
        StartCoroutine (SpawnTarget()); 
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
        spawnRate /= difficulty;
    }
}
