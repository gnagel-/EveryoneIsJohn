using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class toggleLock : MonoBehaviour {

    public Button b;
    public Sprite lockedSprite;
    public Sprite unlockedSprite;

    public bool locked = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (locked)
        {
            b.image.overrideSprite = lockedSprite;
        }
        else
        {
            b.image.overrideSprite = null;
        }
	}

    public void toggle()
    {
        if (locked) { locked = false; }
        else if (!locked) { locked = true; }
    }
}
