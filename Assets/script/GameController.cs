using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject food;
    Vector3 pos;
    Quaternion rot;
    public Text txt;
    public PlayerMover player;

    // Use this for initialization
    void Start()
    {
        pos = new Vector3(Random.Range(-4.8f, 4.8f), 0.5f, Random.Range(-4.8f, 4.8f));
        rot = Quaternion.Euler(Vector3.up);
        Instantiate(food, pos, rot);
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.value < 0.002)
        {
            pos = new Vector3(Random.Range(-4.8f, 4.8f), 0.5f, Random.Range(-4.8f, 4.8f));
            Instantiate(food, pos, rot);
        }
        txt.text = "score:" + player.score;
    }
}
