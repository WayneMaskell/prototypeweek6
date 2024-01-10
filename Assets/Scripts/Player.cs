using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.S)) 
        {
            SetScore(1);

        }
        
    }
    public int GetScore() {  return score; }
    private void SetScore(int value) { score += value; }
}
