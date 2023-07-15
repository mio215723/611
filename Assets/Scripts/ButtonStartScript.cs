using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonStartScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        SceneManager.LoadScene("Game");
    }
}
