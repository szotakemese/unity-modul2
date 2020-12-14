using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ending : MonoBehaviour
{
    public Text ProgressText;
    public Text FoodText;
    private float timeRemaining;

    private void Start()
    {
        ProgressText.text = "";
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            if (Storage.Food < Storage.MaxFood)
            {
                StartCoroutine(GetText());
            }
            else
            {
                FoodText.text = "";
                ProgressText.text = "You Won!";
            }
        }
    }
    IEnumerator GetText() 
    {
        ProgressText.text = "You have to collect all Food!";
        yield return new WaitForSeconds(3f);
        ProgressText.text = "";
    }
}
