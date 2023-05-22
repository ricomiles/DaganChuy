using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuUiManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject titleScreen;
    public GameObject levelSelect;
    public GameObject achievement;
    public GameObject settings;
    [SerializeField] private AudioSource clickAudio;
    [SerializeField] private AudioSource bgAudio;
    private void Awake()
    {
        levelSelect.SetActive(false);
        achievement.SetActive(false);
        settings.SetActive(false);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void showTitleScreen()
    {
        clickAudio.Play();
        bgAudio.Play();
        titleScreen.SetActive(true);
        levelSelect.SetActive(false);
    }

    public void showAchievements()
    {
        clickAudio.Play();
    }
    public void showSettings()
    {
        clickAudio.Play();
    }
    public void showLevelSelect()
    {
        bgAudio.Stop();
        clickAudio.Play();
        titleScreen.SetActive(false);
        levelSelect.SetActive(true);
    }
    public void playSummerDay()
    {
        clickAudio.Play();
        SceneManager.LoadScene("");
    }
    public void playSummerNight()
    {
        clickAudio.Play();
        SceneManager.LoadScene("");
    }
    public void playWinterDay()
    {
        clickAudio.Play();
        SceneManager.LoadScene("");
    }
    public void playWinterNight()
    {

    }
    public void playAutumnDay()
    {
        clickAudio.Play();
        SceneManager.LoadScene("");
    }
    public void playAutumnNight()
    {
        clickAudio.Play();
        SceneManager.LoadScene(""); 
    }
}
