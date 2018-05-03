using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
	public Button yourButton;
	public int ButtonIndex;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{		
		DisplayText.Index = ButtonIndex;
		SceneManager.LoadScene ("Details");
	}
}