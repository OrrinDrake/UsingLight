using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public int playerCurrentHealth = 3;
    public int playerMaxHealth = 3;
    public List<Image> healthRepresentation = new List<Image>();
    public Image Prefab;
    public GameObject canvas;
    private float HorizontalPosition = 1075f / 2f, VerticalPosition = 605f / 2f;
    public Sprite black, white;

    // Use this for initialization
    void Start()
    {
        SetUI();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// Deletes the Ui for the current health bar
    /// </summary>
    public void DeleteUI()
    {
        for (int i = 0; i < healthRepresentation.Count; i++)
        {
            Destroy(healthRepresentation[i].gameObject);
        }
    }

    /// <summary>
    /// Sets the UI for the Current HealthBar
    /// </summary>
    public void SetUI()
    {
        healthRepresentation.Clear();
        HorizontalPosition = 1075f / 2f;
        for (int i = 0; i < playerMaxHealth; i++)
        {
            healthRepresentation.Add((Instantiate(Prefab, canvas.transform) as Image));
            healthRepresentation[i].transform.localScale = Vector3.one;
            healthRepresentation[i].transform.localPosition = new Vector3((-HorizontalPosition + 10), VerticalPosition -25, 0);
            HorizontalPosition -= 60;
        }
    }


    /// <summary>
    /// Sets the sprite to the appropriate color to reflect current health
    /// </summary>
    public void SetCurrentHealth()
    {
        for (int i = 0; i < playerMaxHealth; i++)
        {
            if(i+1> playerCurrentHealth)
            {
                healthRepresentation[i].sprite = black;
            }
            else
            {
                healthRepresentation[i].sprite = white;
            }
        }
    }

    /// <summary>
    /// Updates Max health value and UI
    /// </summary>
    public void UpdateMaxHealth()
    {
        playerMaxHealth++;
        DeleteUI();
        SetUI();
        SetCurrentHealth();
    }

    /// <summary>
    /// Updates Current Health Value and UI
    /// </summary>
    public void GainHealthPack()
    {
        if (!(playerCurrentHealth >= playerMaxHealth))
        {
            playerCurrentHealth++;
            SetCurrentHealth();
        }
    }
}
