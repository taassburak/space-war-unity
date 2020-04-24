using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public GameObject Asteroid;
    public Vector3 randomPos;
    public float waitforstart;
    public float waitforcreation;
    public float waitfornextcreation;
    int score;
    public Text text;
    public Text gameovertext;
    public Text restarttext;
    bool gameovercontrol = false;
    bool gameagain = false;
    void Start()
    {
       score = 0;
       text.text = "score = " + score;
       StartCoroutine (create());
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && gameagain)
        {
            SceneManager.LoadScene("level 1");
        }
    }
    IEnumerator create()
    {
        yield return new WaitForSeconds(waitforstart);
        while (true)
        {
            for (int i = 0; i < 10; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-randomPos.x, randomPos.x), 0, randomPos.z);
                Instantiate(Asteroid, vec, Quaternion.identity);
                yield return new WaitForSeconds(waitforcreation);
            }
            if (gameovercontrol == true)
            {
                restarttext.text = "YENİDEN BAŞLAMAK İÇİN 'R' YE BASINIZ";
                gameagain = true;
                break;
            }

            yield return new WaitForSeconds(waitfornextcreation);
            
        }
        
        
    }
    public void ScoreUp(int ScoreRising)
    {
        
        score += ScoreRising;
        text.text = "score = " + score;
        Debug.Log(score);
    }
    public void gameover()
    {
        gameovertext.text = "GAME OVER(wait for 10sec to play again)";
        gameovercontrol = true;
    }
    
    

   
}
