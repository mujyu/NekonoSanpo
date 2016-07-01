using UnityEngine;
using System.Collections;

public class CloudGenerator : MonoBehaviour {

    public GameObject cloudPrefab;
    private float span = 5f;
    private float deltaT = 0;
    private GameObject cloudGo;
    private int cloudStartYVal = 0;

    void Update () {
        this.deltaT += Time.deltaTime;
        if (this.deltaT > this.span)
        {
            this.deltaT = 0;
            cloudGo = Instantiate(cloudPrefab) as GameObject;
            cloudStartYVal = Random.Range(-1, 6);
            cloudGo.transform.position = new Vector3(45, cloudStartYVal, 6);
        }
	}
}
