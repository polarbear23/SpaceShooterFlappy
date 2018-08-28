using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour {

    public void NextLevelButton(int index)
    {
        //SceneManager.LoadScene(index);
		Application.LoadLevel(index);
    }
}
