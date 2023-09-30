using UnityEngine;

[ExecuteInEditMode]
public class Structure: MonoBehaviour {
	private static ResourceGetter _horBeamPrefabGetter = new ResourceGetter("Prefabs/HorizontalBeam");
	private static ResourceGetter _polePrefabGetter = new ResourceGetter("Prefabs/Pole");

	private static ResourceGetter _blueGetter = new ResourceGetter("Materials/Blue");
	private static ResourceGetter _greenGetter = new ResourceGetter("Materials/Green");
	private static ResourceGetter _redGetter = new ResourceGetter("Materials/Red");

	private GameObject _horizontalBeam = null;
	private GameObject _leftPole = null;
	private GameObject _rightPole = null;

	void Awake() {
		_horizontalBeam = Instantiate(_horBeamPrefabGetter.Resource, transform);
		_leftPole = Instantiate(_polePrefabGetter.Resource, transform);
		_rightPole = Instantiate(_polePrefabGetter.Resource, transform);
		Debug.Log(": ");
	}
}
