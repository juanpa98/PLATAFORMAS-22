using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterItems : MonoBehaviour
{
    public static int numberItem;
    private Text CounterT;
    // Start is called before the first frame update
    void Start()
    {
        CounterT = GetComponent<Text>();
        numberItem = 0;
    }

    // Update is called once per frame
    void Update()
    {
        CounterT.text = "Items: " + numberItem;
    }
}
