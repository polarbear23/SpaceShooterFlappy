using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;//unity5.0
public class fadeIni : MonoBehaviour {

    IEnumerator ChangeLevel()//The IEnumerator allows the program to yield things like the WaitForSeconds function, which lets you tell the script to wait without slowing the CPU
    {
        float fadeTime = GameObject.Find("_GM").GetComponent<Fading>().BeginFade(1);//gets fading component and begins initiates fade
        yield return new WaitForSeconds(fadeTime);//waits the fade time while fading until it is time to load the scene
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//loads scene
		Application.LoadLevel (Application.loadedLevel + 1);
    }
}
