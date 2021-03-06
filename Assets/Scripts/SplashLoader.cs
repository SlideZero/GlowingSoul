using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashLoader : MonoBehaviour {


	public Image _splashImage;
    public Image _estatica;
    public AudioSource _estaticaSonidoSource;

    public string loadLevel;
	public float _wait;


    IEnumerator Start()
    {

        _estaticaSonidoSource = GetComponent<AudioSource>();
        _splashImage.canvasRenderer.SetAlpha(0.0f);
        _estatica.canvasRenderer.SetAlpha(0.0f);


        FadeIn();
        yield return new WaitForSeconds(_wait);
        FadeOut();
        yield return new WaitForSeconds(1.0f);
        FadeOutEstatica();
        yield return new WaitForSeconds(2.5f);

        SceneManager.LoadScene(loadLevel);
    }

	void FadeIn()
	{
		_splashImage.CrossFadeAlpha (1.0f,1.5f, false);
        _estatica.CrossFadeAlpha(0.0f, 1.5f, false);

    }

    void FadeOut()
	{
		_splashImage.CrossFadeAlpha (0.0f,1.5f, false);
        _estatica.CrossFadeAlpha(0.6f, 1.5f, false);
        _estaticaSonidoSource.Play();

    }

    void FadeOutEstatica()
    {
        _estatica.CrossFadeAlpha(0.0f, 1.0f, false);
        

    }

}
