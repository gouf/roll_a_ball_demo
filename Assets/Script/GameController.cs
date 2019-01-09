using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour {
    public UnityEngine.UI.Text ScoreLabel;
    public GameObject winnerLabelObject;

    public void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        ScoreLabel.text = count.ToString();

        if (count.Equals(0))
        {
            winnerLabelObject.SetActive(true);
        }
    }
}
