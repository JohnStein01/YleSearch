using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System;
using UnityEngine.UI;
using System.Collections.Generic;

public class Yle : MonoBehaviour
{
	public GameObject prefabButton;
	public RectTransform ParentPanel;
	public InputField input;
	public static String[] buttonText;
	String keyword;
	bool keyFlag;
	public static YleData YLE;
	public Button SearchButton;

	void Start()
	{				
		keyFlag=false;
		Button sButton=SearchButton.GetComponent<Button> ();
		sButton.onClick.AddListener(StartSearch);
	}

		IEnumerator GetText()
	{	
		using (UnityWebRequest www = UnityWebRequest.Get("https://external.api.yle.fi/v1/programs/items.json?q="+keyword+"&app_id=cc058207&app_key=fa7540a6490efda26e180009be745599"))
		{
			yield return www.Send();
				
			{		
				string str=www.downloadHandler.text;
				YLE = JsonUtility.FromJson<YleData> (str);
				buttonText=new string[YLE.data.Count];					

				for (int i = 0; i < YLE.data.Count-1;i++) {			
					
					buttonText[i]= YLE.data[i].title.fi;
					GameObject goButton = (GameObject)Instantiate(prefabButton,new Vector3(10,110-i*25,0), Quaternion.identity);
					goButton.transform.SetParent(ParentPanel, false);
					goButton.transform.localScale = new Vector3(1, 1, 1);
					goButton.GetComponent<ButtonClick> ().ButtonIndex = i;				 

					if(buttonText[i]!=null)
					goButton.GetComponentInChildren<Text> ().text = buttonText[i];
					
				}			
						
			}
		}
	}

	void StartSearch(){
		keyFlag = true;
	}

	void Update(){
		if ((input.text!=null) && (keyFlag == true)) {
			keyFlag = false;
			keyword = input.text.ToString();
			StartCoroutine (GetText());
		}
	}
}