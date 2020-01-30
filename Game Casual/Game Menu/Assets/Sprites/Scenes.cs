using UnityEngine.SceneManagement;
using UnityEngine;

public class Scenes : MonoBehaviour
{
    //pindah scene ke menu
    public void MenuScene() {
        SceneManager.LoadScene("Menu");
    }

    //pindah scene ke loading
    public void LoadingScene() {
        SceneManager.LoadScene("Laoding");
    }
    //pinda ke keluar scene
    public void KeluarScene() {
        SceneManager.LoadScene("keluar");
    }
}