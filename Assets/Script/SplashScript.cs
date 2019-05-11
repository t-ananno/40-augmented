using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScript : MonoBehaviour {
    private bool finished = false;

	void Start () {
        StartCoroutine(DoFade());
	}
	
    IEnumerator DoFade()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        while (canvasGroup.alpha < 1) {
            canvasGroup.alpha += Time.deltaTime;
            yield return null;
        }
        yield return new WaitForSeconds(1.5f);

        while (canvasGroup.alpha > 0) {
            canvasGroup.alpha -= Time.deltaTime;
            yield return null;
        }
        yield return finished = true;
    }

    private void LateUpdate()
    {
        if (finished==true)
        {
            SceneManager.LoadScene("Scene_01",LoadSceneMode.Single);
        }
    }
	
}
