using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    private int score = 0;
    [SerializeField]
    private TMP_Text _title;
    [SerializeField]
    private int numOfHoops;
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

            if (score == numOfHoops)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            // gameObject.transform.position = new Vector3(3.0f, 3.0f, 3.0f);
        }

    }

}
