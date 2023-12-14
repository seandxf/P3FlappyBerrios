using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameControll : MonoBehaviour
{
    public static GameControll instance;
    public GameObject gameOverText;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;
    private void Awake()
    {
        if (instance == null){
            instance = this;
        } else if (instance != this)
        {
            Destroy(gameObject);
        }
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void BirdDied() 
    {
        gameOverText.SetActive(true);
        gameOver = true;   
    } 
}
