using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonchik : MonoBehaviour
{
  public void StatGame(){
SceneManager.LoadScene("Game");
  }
  
public void BackToMenu()
{
    SceneManager.LoadScene("Menu");
}
 public void ExitGame()
 {

     Debug.Log("Game exit!");
     Application.Quit();
 }
 public void ReloadGame(){
   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
 }
 public void historyGame(){
SceneManager.LoadScene("Menu 1");
  }
}
