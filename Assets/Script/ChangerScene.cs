using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangerScene : MonoBehaviour
{
    static ChangerScene _instance;
    static public ChangerScene instance => _instance;

    [SerializeField] private int _sceneToLoad = 0;
    // public void Jeu()
    // {
    //     SceneManager.LoadScene("Jeu");
    // }

    // public void intro()
    // {
    //     SceneManager.LoadScene("CreationPerso");
    // }

    // public void BadEnding()
    // {
    //     SceneManager.LoadScene("BadEnding");
    // }

    // public void GoodEnding()
    // {
    //     SceneManager.LoadScene("GoodEnding");
    // }

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {

        // if (_instance == null) _instance = this;
    }

    public bool fadeOnStart = true;
    public float fadeDuration = 2;
    public Color fadeColor;
    private Renderer _renderer;
    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    public void FadeIn()
    {
        Fade(1, 0);
    }

    public void FadeOut()
    {
        Fade(0, 1);
        Invoke("ChangerLaScene", fadeDuration);
    }

    public void Fade(float alphaIn, float alphaOut)
    {
        StartCoroutine(FadeRoutine(alphaIn, alphaOut));
    }
    public IEnumerator FadeRoutine(float alphaIn, float alphaOut)
    {

        float timer = 0;
        while (timer <= fadeDuration)
        {

            Color newColor = fadeColor;
            newColor.a = Mathf.Lerp(alphaIn, alphaOut, timer / fadeDuration);

            _renderer.material.SetColor("_Color", newColor);


            timer += Time.deltaTime;
            yield return null;
        }
        Color newColor2 = fadeColor;
        newColor2.a = alphaOut;
        _renderer.material.SetColor("_Color", newColor2);

        yield break;
    }

    private void ChangerLaScene()
    {
        SceneManager.LoadScene(_sceneToLoad);
    }


}