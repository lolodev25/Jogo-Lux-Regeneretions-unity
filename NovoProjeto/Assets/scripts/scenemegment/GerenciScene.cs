using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GerenciScene : MonoBehaviour
{

    [SerializeField] private CanvasGroup loadingover;
    [SerializeField] [Range(0.01f,3f)] private float fadetime = 0.5f;
    

    public static GerenciScene instance { get; private set; }


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }


    }

   

    public void loadscena(string scenename)
    {
        StartCoroutine(Performload(scenename));

    }

    private IEnumerator Performload(string scenename)
    {
        yield return StartCoroutine(fadein());

        var operacion = SceneManager.LoadSceneAsync(scenename);

        while (operacion.isDone == false)
        {
            yield return null;
        }

        yield return StartCoroutine(fadeout());
    }
  
    private IEnumerator fadein()
    {
        float start = 0;
        float end = 1;
        float speed = (end - start) / fadetime;
        loadingover.alpha = start;
        while (loadingover.alpha < end)
        {
            loadingover.alpha += speed * Time.deltaTime;
            yield return null;
        }
        loadingover.alpha = end;
    }

    private IEnumerator fadeout()
    {
        float start = 1;
        float end = 0;
        float speed = (end - start) / fadetime;
        loadingover.alpha = start;
        while (loadingover.alpha > end)
        {
            loadingover.alpha += speed * Time.deltaTime;
            yield return null;
        }
        loadingover.alpha = end;
    }




}
