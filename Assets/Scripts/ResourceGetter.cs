using UnityEngine;

public class ResourceGetter<T> where T: Object {
	private T _resource;

	private string _resourcePath = null;

	public T Resource {
		get {
			if(_resource == null) {
				_resource = Resources.Load<T>(_resourcePath);
			}
			return _resource;
		}
	}

	public ResourceGetter(string pResourcePath) {
		_resourcePath = pResourcePath;
	}
}
