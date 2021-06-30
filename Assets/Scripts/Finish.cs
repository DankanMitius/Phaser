using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Finish : MonoBehaviour
{
    public Camera main;
    public Camera cameraDance;
    public AudioSource background;
    public AudioSource thriller;
    public static bool danceof;
    // Start is called before the first frame update
    private void Start()
    {
        main.enabled = true;
        cameraDance.enabled = false;
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            main.enabled = false;
            cameraDance.enabled = true;
            background.mute=true;
            thriller.mute = false;
            thriller.Play();
            StartCoroutine(End());
            danceof = true;
        }
    }
    public IEnumerator End()
    {

      
        yield return new WaitForSeconds(39);
        SceneManager.LoadScene("MainMenu");
    }
}
