using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Reflection;

public class DangerWall : MonoBehaviour {
    public GameObject WinnerLabelObject;

    private void OnCollisionEnter(Collision collision)
    {
        if (WinnerLabelObject.activeSelf.Equals(true))
        {
            return;
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;

            SceneManager.LoadScene(sceneIndex);
        }
    }
}
