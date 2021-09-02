
using UnityEngine;

public class ButtonPressAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var hash = iTween.Hash("scale", new Vector3(1.1f, 1.1f, 1.1f), "time", 1, "looptype", "pingpong", "EaseType", "easeInBack");
        iTween.ScaleTo(gameObject, hash);
    }
    
}
