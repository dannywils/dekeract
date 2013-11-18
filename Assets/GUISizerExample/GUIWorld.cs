using UnityEngine;
using System.Collections;


public class GUIWorld : MonoBehaviour 
{
	public GameObject watchObj;
	public bool invertColors = false;
	public Camera relativeToCam;
	public int height = 25;
	public int width = 200;
	public GUIStyle style;
	private GUIStyle style2;
	private Color guiColor;
	
	public string myText = string.Empty;
	void Start()
	{
		if (!relativeToCam)
			relativeToCam = Camera.main;
		
		style2 = style;
		
		if (!invertColors)
		{
			style2.normal.textColor = Color.black;
			guiColor = Color.white;
		}
		else
		{
			style2.normal.textColor = Color.white;
			guiColor = Color.black;

		}
			
		guiColor.a = 1f;
	}
	
	void OnGUI () 
	{
		if ((watchObj && !watchObj.activeSelf) || !watchObj)
		{
			style2.normal.textColor = Color.black;
			style2.normal.textColor = new Color(style2.normal.textColor.r,  style2.normal.textColor.g, style2.normal.textColor.b, 1f);
			GUI.Box(new Rect(relativeToCam.WorldToScreenPoint(this.transform.position).x+1, relativeToCam.pixelHeight-relativeToCam.WorldToScreenPoint(this.transform.position).y-height+1, width, height), myText, style2);
		
			style.normal.textColor = guiColor;
			GUI.Box(new Rect(relativeToCam.WorldToScreenPoint(this.transform.position).x, relativeToCam.pixelHeight-relativeToCam.WorldToScreenPoint(this.transform.position).y-height, width, height), myText, style);
		}
	}
	
	void SetText(string text)
	{
		myText = text;
	}
}
