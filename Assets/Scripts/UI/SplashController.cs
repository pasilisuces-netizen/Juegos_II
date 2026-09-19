using System.Collections;
using UnityEngine;

public class SplashController : MonoBehaviour
{
    [SerializeField] private CanvasGroup group;
    [SerializeField] private float fadeTime = 0.8f;
    [SerializeField] private float holdTime = 1.5f;
    [SerializeField] private string nextScene = "01_MainMenu";

    private IEnumerator Start()
    {
        yield return Fade(0f, 1f);
        yield return new WaitForSeconds(holdTime);
        yield return Fade(1f, 0f);
        SceneLoader.Instance.Load(nextScene);
    }

    private IEnumerator Fade(float from, float to)
    {
        float t = 0f;
        while (t < fadeTime)
        {
            t += Time.deltaTime;
            group.alpha = Mathf.Lerp(from, to, t / fadeTime);
            yield return null;
        }
        group.alpha = to;
    }
}