using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerEscenas : MonoBehaviour
{
    public void GamePlayScene(){
        SceneManager.LoadScene("Game");
    }

    public void MenuPrincipalScene(){
        SceneManager.LoadScene("Menu_Principal");
    }
}
