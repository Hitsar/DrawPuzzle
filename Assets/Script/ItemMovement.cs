using System.Collections;
using UnityEngine;

namespace Script
{
    public class ItemMovement : MonoBehaviour
    {
        private LineRenderer _lineRenderer;
        private Vector3[] _points;
        private int _step;

        private void Start() => _lineRenderer = GetComponentInParent<LineRenderer>();
        
        public void CheckLine() 
        {
            _points = new Vector3[_lineRenderer.positionCount];
            _lineRenderer.GetPositions(_points);
            StartCoroutine(Move());
        }

        private IEnumerator Move() 
        {
            while(_step < _points.Length) 
            {
                transform.position = Vector3.MoveTowards(transform.position, _points[_step], Time.deltaTime * (_points.Length / 2));
                if(Vector3.Distance(transform.position, _points[_step]) < 0.2f) 
                {
                    _step++;
                }
                yield return null;
            }
        }

        public void Stop() => StopCoroutine(Move());
    }
}