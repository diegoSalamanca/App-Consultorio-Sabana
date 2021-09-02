
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderManager : MonoBehaviour
{

    CanvasGroup canvasGroup;
    // Start is called before the first frame update
    public bool unloader;

    void Start()
    {
        if (unloader)
        {
            
            var alphatween = 1f;
            var hash = iTween.Hash("from", alphatween, "to", 0f, "time", 1f, "onupdate", "UpdateAlpha");
            iTween.ValueTo(gameObject, hash);
        }
        canvasGroup = GetComponent<CanvasGroup>();
    }

    

    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void StartLoadLevel(string level)
    {
        canvasGroup.blocksRaycasts = true;
        
        var alphatween = 0f;
        var hash = iTween.Hash("from", alphatween,"to", 1f, "time", 1f, "onupdate", "UpdateAlpha", "oncomplete", "LoadLevel", "oncompleteparams", level);
        iTween.ValueTo(gameObject, hash);
    }

    public void UpdateAlpha(float value)
    {
        canvasGroup.alpha = value;
    }
}
