using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class setName : MonoBehaviour {

    public Text pName;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        pName.text = playController.playerName;
	}
}
