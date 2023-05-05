using System;
using System.Collections;
using UnityEngine;

namespace Script.Item
{
    public class ItemMovement : MonoBehaviour
    {
        [SerializeField] private PathCollectorData _pathCollectorData;
        private LineRenderer _lineRenderer;
        private Vector3[] _points;
        private int _step;

        private void Start() 
        {
            _lineRenderer = GetComponentInParent<LineRenderer>();
        }

        private void OnEnable() => _pathCollectorData.MoveItem += GetRoute;
        private void OnDisable() => _pathCollectorData.MoveItem -= GetRoute;

        private void GetRoute() 
        {
            _points = new Vector3[_lineRenderer.positionCount];
            _lineRenderer.GetPositions(_points);
            StartCoroutine(Move());
        }

        private IEnumerator Move() 
        {
            while(_step < _points.Length) 
            {
                transform.position = Vector3.MoveTowards(transform.position, _points[_step], Time.deltaTime * _points.Length / 2);
                if(Vector3.Distance(transform.position, _points[_step]) < 0.2f) 
                {
                    _step++;
                }
                yield return null;
            }
        }

        public void Stop() => _step = Int32.MaxValue;
    }
}