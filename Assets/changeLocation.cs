using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  

public class changeLocation : MonoBehaviour
{
 public void loadScene(int sceneNumber) {  
        SceneManager.LoadScene(sceneNumber);  
    }   
}
