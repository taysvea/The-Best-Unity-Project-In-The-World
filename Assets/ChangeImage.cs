using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class ChangeImage : MonoBehaviour {
	public Renderer skyboxTop;
	public Renderer skyboxBottom;
	public Material skyTop;
	public Material skyBottom;

	private int currentSky = 0;
	
	void Start () {
		
	}
	
	public void clickerChange() {
		switch (currentSky) {
		case 0:
			skyboxTop.material = skyTop;
			skyboxBottom.material = skyBottom;
			currentSky++;
			break;
		case 1:
			skyboxTop.material = skyTop;
			skyboxBottom.material = skyBottom;
			currentSky = 0;
			break;
		}
	}
	public void stareChange() {
		GetComponent<ParticleSystem>().Emit(10); 
	}
}
