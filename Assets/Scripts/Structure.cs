using UnityEngine;

[ExecuteInEditMode]
public class Structure: MonoBehaviour {
	private static ResourceGetter _horBeamPrefabGetter = new ResourceGetter("Prefabs/HorizontalBeam");
	private static ResourceGetter _polePrefabGetter = new ResourceGetter("Prefabs/Pole");

	private static ResourceGetter _blueGetter = new ResourceGetter("Materials/Blue");
	private static ResourceGetter _greenGetter = new ResourceGetter("Materials/Green");
	private static ResourceGetter _redGetter = new ResourceGetter("Materials/Red");

	private const string NAME_HORIZONTAL_BEAM = "HorizontalBeam";
	private const string NAME_LEFT_POLE = "LeftPole";
	private const string NAME_RIGHT_POLE = "RightPole";

	private GameObject _horizontalBeam = null;
	private GameObject _leftPole = null;
	private GameObject _rightPole = null;

	void Awake() {
		GameObject polePrefab = _polePrefabGetter.Resource;
		_horizontalBeam = Instantiate(_horBeamPrefabGetter.Resource, transform);
		_horizontalBeam.name = NAME_HORIZONTAL_BEAM;
		_leftPole = Instantiate(polePrefab, transform);
		_leftPole.name = NAME_LEFT_POLE;
		_rightPole = Instantiate(polePrefab, transform);
		_rightPole.name = NAME_RIGHT_POLE;

		Transform beamTransform = _horizontalBeam.transform;
		Transform rightPoleTransform = _rightPole.transform;
		Vector3 beamScale = beamTransform.localScale;
		float poleHeight = rightPoleTransform.localScale.y;

		Vector3 beamPosition = new Vector3(0f, poleHeight + beamScale.y / 2, 0f);
		beamTransform.position = beamPosition;

		float polePositionX = (beamScale.x - 3) / 2;
		float polePositionY = poleHeight / 2;
		rightPoleTransform.position = new Vector3(polePositionX, polePositionY, 0f);
		_leftPole.transform.position = new Vector3(-polePositionX, polePositionY, 0f);
	}
}
