using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartUp : MonoBehaviour
{
    private Toggle onePlayer, twoPlayers, level3;
    GameManager gm;


    // Start is called before the first frame update
    void Start()
    {
        onePlayer = GameObject.Find("Toggle1").GetComponent<Toggle>();
        twoPlayers = GameObject.Find("Toggle2").GetComponent<Toggle>();
        level3 = GameObject.Find("Toggle3").GetComponent<Toggle>();
        onePlayer.Select();
        gm = GameManager.GetInstance();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            gm.playerLife[0] = 3;
            if (twoPlayers.isOn)
            {
                gm.playerLife[0] = 3;
                gm.playerLife[1] = 3;
                gm.player = 2;
                SceneManager.LoadScene(/*"BattleScene"*/2);
            }
            else if (onePlayer.isOn)
            {
                gm.playerLife[0] = 3;
                gm.playerLife[1] = 0;
                gm.player = 1;
                SceneManager.LoadScene(/*"BattleScene"*/2);
            }
            else if (level3.isOn)
            {
                SceneManager.LoadScene("BattleScene3");
            }
            
        }

    }
}
