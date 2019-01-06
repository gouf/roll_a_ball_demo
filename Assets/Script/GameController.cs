using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour {
    public UnityEngine.UI.Text ScoreLabel;
    public void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        ScoreLabel.text = count.ToString();
    }
}
