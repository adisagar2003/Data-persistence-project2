using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField]
    private InputField Inputfield;
    public string username;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        // take the value of InputField, move to another scene
        username = Inputfield.text.ToString();
        if (username!="")
        {
            DontDestroyOnLoad(this.gameObject);
            SceneManager.LoadScene("main");
        }

    }
}
