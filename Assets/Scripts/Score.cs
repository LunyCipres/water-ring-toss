using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    private static int score = 0;
    [SerializeField]
    private TMP_Text _title;

    //depicts total number of hoops in the level, used to check if level is complete
    public int numOfHoops;
    //next level button
    public GameObject LevelButton;

    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "water_peg")
        {
            print("Collided");

            // gameObject.transform.position = new Vector3(3.0f, 3.0f, 3.0f);
        }

    }*/
    //public GameObject water_peg;
    private void OnTriggerEnter(Collider collision1)
    {
        if (collision1.gameObject.tag == "score")
        {
            score++;
            print("score=" + (score));
            _title.text = "<b>" + score.ToString() + "<b>";

            //check if level is complete
            if (score == /*1*/numOfHoops) {
                print("level complete");
                // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                if (LevelButton != null) {
                    //debug line
                    print("next level");

                    LevelButton.SetActive(true);
                }
            }
            // gameObject.transform.position = new Vector3(3.0f, 3.0f, 3.0f);
        }

    }

}
