using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class uiManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject loginScreen;
    public GameObject registerScreen;
    public static uiManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showLoginScreen()
    {
        loginScreen.SetActive(true);
        registerScreen.SetActive(false);
    }
    public void showRegisterScreen()
    {
        registerScreen.SetActive(true);
        loginScreen.SetActive(false);
    }
    public void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
