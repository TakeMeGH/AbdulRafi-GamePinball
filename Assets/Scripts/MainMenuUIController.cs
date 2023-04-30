using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuUIController : MonoBehaviour
{
  public Button playButton;
  public Button exitButton;
  public Button creditButton;

  // Start is called before the first frame update
  void Start()
  {
    playButton.onClick.AddListener(PlayGame);
    exitButton.onClick.AddListener(ExitGame);
    creditButton.onClick.AddListener(CreditScene);
  }

  // Update is called once per frame
  public void PlayGame()
  {
    SceneManager.LoadScene("MainScene");
  }

  public void ExitGame()
  {
    Application.Quit();
  }

  public void CreditScene(){
    SceneManager.LoadScene("CreditScene");
  }
}
