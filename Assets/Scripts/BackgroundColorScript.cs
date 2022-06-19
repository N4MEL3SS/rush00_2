using System;
using UnityEngine;

public class BackgroundColorScript : MonoBehaviour
{
	public float duration = 3.0f;
	public Color color1 = new Color(0.31f, 0.62f, 1f);
	public Color color2 = new Color(0.72f, 0.09f, 1f);
	
	private void Update()
	{
		var t = Mathf.PingPong(Time.time, duration) / duration;
		Camera.main!.backgroundColor = Color.Lerp(color1, color2, t);
	}
}
