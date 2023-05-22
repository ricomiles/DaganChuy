using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiController : MonoBehaviour
{
    // Start is called before the first frame update
    Player player;
    Text distanceText;

    GameObject results;
    GameObject pauseMenu;
    Text finalDistanceText;

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        distanceText = GameObject.Find("DistanceText").GetComponent<Text>();
        finalDistanceText = GameObject.Find("FinalDistanceText").GetComponent<Text>();
        results = GameObject.Find("Results");
        pauseMenu = GameObject.Find("PauseMenu");
        results.SetActive(false);
        pauseMenu.SetActive(false);
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int distance = Mathf.FloorToInt(player.distance);
        distanceText.text = distance + " m";
        if (player.isDead)
        {
            results.SetActive(true);
            finalDistanceText.text = distance + " m";
        }
    }

    public void Quit()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public void Retry()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    
}
