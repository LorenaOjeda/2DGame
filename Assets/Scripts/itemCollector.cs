using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class itemCollector : MonoBehaviour
{
    private int coins = 0;

    [SerializeField] private TMP_Text coinsText;

/*
    private string coinsPrefsName = "Coins";

    private void Awake()
    {
        LoadData();
    }
*/

    
    private void OnTriggerEnter2D(Collider2D collision)  
    {
        if (collision.gameObject.name.Equals("coin"))
        {
            Destroy(collision.gameObject);
            coins++;
            coinsText.text = "Monedas: " + coins; 
        }
    }

    
/*
    private void OnDestroy()
    {
        SaveData();
    }


    private void SaveData()
    {
        PlayerPrefs.SetInt(coinsPrefsName, coins);
    }

    private void LoadData()
    {
        coins = PlayerPrefs.GetInt(coinsPrefsName, 0);
    }
*/
   
} 
