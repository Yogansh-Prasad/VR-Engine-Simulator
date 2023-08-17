using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EngineGame : MonoBehaviour
{
    public GameObject[] engineParts; // Array of engine part objects
    public TMP_Text questionText; // Text element to display the question
    public TMP_Text scoreText; // Text element to display the score
    public Transform[] spawnLocations; // Array of spawn locations    
    public string[] qparts;
    public Button playbutton;
    public Button nextbutton;
    public Button replaybutton;
    

    private int roundCount = 0; // Number of rounds played
    private int correctPartIndex; // Index of the correct engine part
    private int score = 0; // Player's score
    private List<GameObject> spawnedObjects = new List<GameObject>();

    void Start()
    {
        questionText.text = "Press the button to start the quiz.";
        scoreText.text = "Score: 0";
                
    }

    public void StartGame()
    {
        roundCount = 0;
        score = 0;
        scoreText.text = "Score: 0";
        NextRound();
        scoreText.gameObject.SetActive(true );
        playbutton.gameObject.SetActive(false);
        replaybutton.gameObject.SetActive(false);
    }

    public void OnPartSelected(int selectedPartIndex)
    {
        bool answeredCorrectly = selectedPartIndex == correctPartIndex;

        if (answeredCorrectly)
        {
            score++;
            UpdateQuestionText("Correct! Well done!");
        }
        else
        {
            UpdateQuestionText("Incorrect part selected.");
        }

        scoreText.text = "Score: " + score.ToString();
        nextbutton.gameObject.SetActive(true);

    }

    private void NextRound()
    {
        roundCount++;
        int correctPartPosition;

        // Clear previous parts from the table
        
        foreach(GameObject spawnedObject in spawnedObjects)
        {
            Destroy(spawnedObject);
        }
        spawnedObjects.Clear();
        // Choose a new question and display it
        questionText.text = "Round " + roundCount.ToString() + ": Identify the correct engine part:" + qparts[roundCount-1];

        // Instantiate new parts on the table
        correctPartIndex =roundCount-1;
        correctPartPosition =Random.Range(0,3);
        for (int i = 0; i < 3; i++)
        {
            if (i == correctPartPosition)
            {
                GameObject CPart_Spawned = Instantiate(engineParts[correctPartIndex], spawnLocations[i].position, spawnLocations[i].rotation);
                spawnedObjects.Add(CPart_Spawned);
                continue;
            }
            int randomPartIndex = Random.Range(0, engineParts.Length);            
            GameObject Part_Spawned=Instantiate(engineParts[randomPartIndex], spawnLocations[i].position, spawnLocations[i].rotation);
            spawnedObjects.Add(Part_Spawned);          

        }
        Debug.Log(correctPartPosition+"Part position");
        Debug.Log(correctPartIndex+"Part Index");
    }

    private void EndGame()
    {
        scoreText.gameObject.SetActive(false);
        questionText.text = "Quiz Completed! Your final score is: " + score.ToString()+"/8";
        replaybutton.gameObject.SetActive(true);
    }
    private void UpdateQuestionText(string message)
    {
        questionText.text = message;
    }
    public void nextButton() 
    {

        nextbutton.gameObject.SetActive(false);
        if (roundCount < 8)
        {
            NextRound();
        }
        else
        {
            EndGame();
        }
    }
}
