using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    
    public Text FoodText;

    void Start()
    {
        
    }
    void Update()
    {
        if (!Storage.isEnd)
        {
            FoodText.text = "Food: " + Storage.Food.ToString() + " / " + Storage.MaxFood.ToString();
            if (Storage.Food == Storage.MaxFood)
            {
                FoodText.text = "\nAll Food collected \nFind the Exit";
            }
        }
    }
}
