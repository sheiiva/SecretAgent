using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 0.5f;

    public void LoadLevel(string level)
    {
       StartCoroutine(MakeTransitionAndLoad(level));
    }

    private IEnumerator MakeTransitionAndLoad(string level)
    {
        // Make transition
        transition.SetTrigger("Start");

        // Wait
        yield return new WaitForSeconds(transitionTime);

        // Load new Scene
        SceneManager.LoadScene(level);
    }
}
