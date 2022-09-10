using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    private int score = 0;
    [SerializeField]
    private TMP_Text _title;
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
            _title.text = score.ToString();


            // gameObject.transform.position = new Vector3(3.0f, 3.0f, 3.0f);
        }

    }

}
