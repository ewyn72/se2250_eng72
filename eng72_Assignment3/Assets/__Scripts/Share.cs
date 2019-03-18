using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Share : MonoBehaviour
{ 
/* Share on Twitter */
string twitterAddress = "http://twitter.com/intent/tweet";
    string tweetLang = "en";
    string txt = "My highscore: ";
    int highscore = ScoreManager.HIGH_SCORE;
    public void shareScoreOnTwitter()
    {
        Application.OpenURL(twitterAddress + "?text=" + WWW.EscapeURL(txt) + highscore + "&amp:lang=" + WWW.EscapeURL(tweetLang));
    }

}
