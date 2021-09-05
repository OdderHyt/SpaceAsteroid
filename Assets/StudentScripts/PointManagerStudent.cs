using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointManagerStudent : MonoBehaviour
{
    public Text pointDisplay;
    public string displayText = "Points: ";
    public int totalPoints;
    public static PointManagerStudent Instance;

    #region Singleton
    private void Awake() {
        if (Instance != null && Instance != this) {
            
            Destroy(gameObject);
        } else {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }
    #endregion
    void Start() {
        ResetPoints();
    }

    public void AddPoints(int pointsToAdd) {
        // tilføj kode her
    }

    public void ResetPoints() {
        // tilføj kode her
    }
}

