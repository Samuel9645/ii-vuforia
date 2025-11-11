using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ChangeColor : MonoBehaviour {
  private void Awake() {
    _renderer = GetComponent<Renderer>();
  }

  public void ChangeToRandomColor() {
    if (_renderer != null) {
      _renderer.material.color = Random.ColorHSV();
    }
  }
  private Renderer _renderer;
}
