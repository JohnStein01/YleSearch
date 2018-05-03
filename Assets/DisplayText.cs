using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayText : MonoBehaviour {

	public Text DetailsText;
	public static int Index;
	public Button BackButton;
	// Use this for initialization
	void Start () {		
		DetailsText.text = Yle.YLE.data [Index].title.fi+"\n\n"+Yle.YLE.data [Index].type+"\n\n"+Yle.YLE.data [Index].description.fi+"\n\n"+Yle.YLE.data [Index].id+"\n\n"+Yle.YLE.data [Index].productionId;
		BackButton = BackButton.GetComponent<Button>();
		BackButton.onClick.AddListener(BackOnClick);
	}
	
	// Update is called once per frame
	void BackOnClick()
	{				
		SceneManager.LoadScene ("Yle");
	}
}
