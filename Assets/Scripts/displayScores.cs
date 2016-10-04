using UnityEngine;
using System.Collections;

public class displayScores : MonoBehaviour {
    //private TextMesh letter;
    private GameObject letterObject;
    private TextMesh letterText;
    private GameObject scoreObject;
    private TextMesh scoreText;

    // Use this for initialization
    void Start () {
        //letter = this.gameObject.GetComponentInChildren<TextMesh>();
        GameObject controller = GameObject.Find("Controller (left)");
        ContactNotes contactNotes = controller.GetComponent<ContactNotes>();

        letterObject = this.transform.Find("letterGrade").gameObject;
        letterText = letterObject.GetComponent<TextMesh>();
        scoreObject = this.transform.Find("numberScore").gameObject;
        scoreText = letterObject.GetComponent<TextMesh>();

        int playerScore = contactNotes.playerScore();
        scoreText.text = playerScore.ToString();
        letterText.text = contactNotes.gradeGenerator(playerScore);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
