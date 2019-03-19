using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SocialButton : MonoBehaviour
{

    public Button socialButton;

    // Start is called before the first frame update
    void Start()
    {
        socialButton.onClick.AddListener(ShareToTwitter);
    }


    // Social Media Share Function, to be called on game over (in function below)
    public void ShareToTwitter()
    {
        string urlString = "http://twitter.com/home?status=";
        urlString += "Check%20out%20my%20score%20of%20";
        urlString += ScoreManager.SCORE;
        urlString += "%20on%20Prospector%20Solitaire!";
        Application.OpenURL(urlString);
    }
}
