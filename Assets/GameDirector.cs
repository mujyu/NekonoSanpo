using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

    GameObject car;
    GameObject flag;
    GameObject distance;
    GameObject clock;
    GameObject saveText;
    private float flagDistance = 0;
    private float score = 0;
    private float sumScore = 0;
    private Vector3 carPos;

	// Use this for initialization
	void Start () {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
        this.clock = GameObject.Find("Clock");
        this.saveText = GameObject.Find("SaveText");
        //セーブスコアのロード
        sumScore = PlayerPrefs.GetFloat("score");
	}
	
	// Update is called once per frame
	void Update () {
        System.DateTime nowTime = System.DateTime.Now;
        score = (this.flag.transform.position.x - this.car.transform.position.x) * -1;
        flagDistance = this.flag.transform.position.x - this.car.transform.position.x;
        score = CarController.speedX;
        sumScore += score / 50;
        this.distance.GetComponent<Text>().text = "さんぽきょり:" + sumScore.ToString("F3") + "km";
        this.clock.GetComponent<Text>().text = nowTime.ToString("HH:mm ss");
        if (flagDistance <= -35)
        {
            this.carPos.x = -23;
            this.carPos.y = -4.329838f;
            this.carPos.z = -1;
            this.car.transform.position = carPos;
            ScoreSave();
        }   
	}
    private void ScoreSave()
    {
        PlayerPrefs.SetFloat("score",sumScore);
    }
}
