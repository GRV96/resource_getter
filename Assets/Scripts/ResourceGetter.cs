using UnityEngine;

public class ResourceGetter {
	private GameObject _resource = null;

	private string _resourcePath = null;

	public GameObject Resource {
		get {
			if(_resource == null) {
				_resource = Resources.Load<GameObject>(_resourcePath);
			}
			return _resource;
		}
	}

	public ResourceGetter(string pResourcePath) {
		_resourcePath = pResourcePath;
	}
}
