using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    public Text pointDisplay;
    public string displayText = "Points: ";
    public int points;
    private static PointManager Instance;

    private void Awake() {
        if (Instance == null) {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }
    void Start() {
        ResetPoints();
    }
    private void Update() {
        pointDisplay.text = displayText + points.ToString();
    }

    public void AddPoints(int pointsToAdd) {
        points += pointsToAdd;
    }

    public void ResetPoints() {
        points = 0;
    }
}

