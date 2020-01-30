using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
 
 //waktu delay untuk load scene
 [SerializeField] private float delayLoading = 3f;

 //nama scene untuk pindah sceneyang di input kan pada Inspector
 [SerializeField] private string nameScene;

 private float timeElapsed;

 private void update () {
     timeElapsed += Time.deltaTime;

     if (timeElapsed > delayLoading) {
         SceneManager.LoadScene(nameScene);
     }
 }    
}