using UnityEngine;
using System.Collections;

public class GUITest : MonoBehaviour 
{
	//style that can be edited from Inspector
	[SerializeField]
	private GUIStyle customStyle;
	
	[SerializeField]
	private GameObject cube;
	
	GUISizer.GUIParams button1 = new GUISizer.GUIParams(GUISizer.PositionDef.middle, "Middle");
	GUISizer.GUIParams button2 = new GUISizer.GUIParams(GUISizer.PositionDef.topLeft, "TopLeft");
	GUISizer.GUIParams button3 = new GUISizer.GUIParams(GUISizer.PositionDef.topMiddle, "TopMiddle");
	GUISizer.GUIParams button4 = new GUISizer.GUIParams(GUISizer.PositionDef.topRight, "TopRight");
	GUISizer.GUIParams button5 = new GUISizer.GUIParams(GUISizer.PositionDef.left, "Left");
	GUISizer.GUIParams button6 = new GUISizer.GUIParams(GUISizer.PositionDef.right, "Right");
	GUISizer.GUIParams button7 = new GUISizer.GUIParams(GUISizer.PositionDef.bottomLeft, "BottomLeft");
	GUISizer.GUIParams button8 = new GUISizer.GUIParams(GUISizer.PositionDef.bottomMiddle, "Bottom");
	GUISizer.GUIParams button9 = new GUISizer.GUIParams(GUISizer.PositionDef.bottomRight, "BottomRight");
	
	GUISizer.GUIParams label1 = new GUISizer.GUIParams(GUISizer.WIDTH/2 - GUISizer.MEDIUM_BUTTON_WIDTH/2, GUISizer.HEIGHT/2 - GUISizer.MEDIUM_BUTTON_HEIGHT, GUISizer.MEDIUM_BUTTON_WIDTH, GUISizer.MEDIUM_BUTTON_HEIGHT, "Pressed: none");
	
	private string cachedText = "none";
	void AppendLabel(string text)
	{
		//remove the previously appended text
		if (label1.text.EndsWith(cachedText))
		{
			label1.text = label1.text.Substring(0, label1.text.LastIndexOf(cachedText));
		}
		
		label1.text += text;
		
		cachedText = text;
		
		cube.rigidbody.AddForce(Random.Range(-1000f, 1000f), Random.Range(-1000f, 1000f), Random.Range(-1000f, 1000f));
	}
	
	void OnGUI()
	{
		GUISizer.BeginGUI(GUISizer.PositionDef.middle);
		
		if (GUISizer.ButtonPressed(button1))
		{
			Camera.main.backgroundColor = new Color (Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
			AppendLabel(button1.text);
		}
		
		GUISizer.MakeLabel(label1, 20, customStyle);
		
		GUISizer.EndGUI();
		
		GUISizer.BeginGUI(GUISizer.PositionDef.topLeft);
		
		if (GUISizer.ButtonPressed(button2))
		{
			Camera.main.backgroundColor = new Color (Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
			AppendLabel(button2.text);
		}
		
		GUISizer.EndGUI();

		
		GUISizer.BeginGUI(GUISizer.PositionDef.topMiddle);
		
		if (GUISizer.ButtonPressed(button3))
		{
			Camera.main.backgroundColor = new Color (Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
			AppendLabel(button3.text);
		}
		
		GUISizer.EndGUI();

		GUISizer.BeginGUI(GUISizer.PositionDef.topRight);
		
		if (GUISizer.ButtonPressed(button4))
		{
			Camera.main.backgroundColor = new Color (Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
			AppendLabel(button4.text);
		}
		
		GUISizer.EndGUI();

		
		GUISizer.BeginGUI(GUISizer.PositionDef.left);
		
		if (GUISizer.ButtonPressed(button5))
		{
			Camera.main.backgroundColor = new Color (Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
			AppendLabel(button5.text);
		}
		
		GUISizer.EndGUI();

		
		GUISizer.BeginGUI(GUISizer.PositionDef.right);
		
		if (GUISizer.ButtonPressed(button6))
		{
			Camera.main.backgroundColor = new Color (Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
			AppendLabel(button6.text);
		}
		
		GUISizer.EndGUI();

		
		GUISizer.BeginGUI(GUISizer.PositionDef.bottomLeft);
		
		if (GUISizer.ButtonPressed(button7))
		{
			Camera.main.backgroundColor = new Color (Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
			AppendLabel(button7.text);
		}
		
		GUISizer.EndGUI();

		
		GUISizer.BeginGUI(GUISizer.PositionDef.bottomMiddle);
		
		if (GUISizer.ButtonPressed(button8))
		{
			Camera.main.backgroundColor = new Color (Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
			AppendLabel(button8.text);
		}
		
		GUISizer.EndGUI();

		
		GUISizer.BeginGUI(GUISizer.PositionDef.bottomRight);
		
		if (GUISizer.ButtonPressed(button9))
		{
			Camera.main.backgroundColor = new Color (Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
			AppendLabel(button9.text);
		}
		
		GUISizer.EndGUI();
	}
}
