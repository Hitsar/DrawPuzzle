using UnityEngine;

namespace Script
{
    public class DrawingLine : MonoBehaviour
    {
        private FinishChecker _finishChecker;
        private LineRenderer _lineRenderer;
        private Camera _cameraMain;
        private float _time;

        private void Start() => _cameraMain = Camera.main;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit2D hit = Physics2D.Raycast(_cameraMain.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                if (hit.collider.gameObject.TryGetComponent(out LineRenderer lineRenderer))
                {
                    _lineRenderer = lineRenderer;
                    _finishChecker = lineRenderer.gameObject.GetComponentInChildren<FinishChecker>();
                }
            }

            if (Input.GetMouseButton(0))
            {
                Vector2 mousePosition = _cameraMain.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
                Draw(_lineRenderer, mousePosition);
            }

            if (Input.GetMouseButtonUp(0) && _finishChecker.LineComeFinish(this))
            {
                _lineRenderer = null;
            }
        }

        private void Draw(LineRenderer lineRenderer, Vector2 position)
        {
            _time -= Time.deltaTime;
            if (_time <= 0)
            {
                lineRenderer.positionCount++;
                lineRenderer.SetPosition(lineRenderer.positionCount - 1, position);
                _time = 0.01f;
            }
        }

        public void Clear() => _lineRenderer.positionCount = 0;
    }
}