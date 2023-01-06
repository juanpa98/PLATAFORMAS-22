using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WIN : MonoBehaviour
{
    public GameObject WinText;
    public static GameObject WinStatic;

    // Start is called before the first frame update
    void Start()
    {
        WIN.WinStatic = WinText;
        WIN.WinStatic.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void show()
    {
        WIN.WinStatic.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
