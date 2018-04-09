using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PolyNav;

[RequireComponent(typeof(CompositeCollider2D))]
[RequireComponent(typeof(PolyNavObstacle))]
public class CompositePolynav : MonoBehaviour
{

    private CompositeCollider2D _comp;
	private PolyNavObstacle _obstacle;
    // Use this for initialization
    void Start()
    {
        _comp = GetComponent<CompositeCollider2D>();
		_obstacle = GetComponent<PolyNav.PolyNavObstacle>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private

    void getPoly()
    {
        List<Vector2> verts = new List<Vector2>();

        for (int i = 0; i < _comp.pathCount; i++)
        {
            Vector2[] pathVerts = new Vector2[_comp.GetPathPointCount(i)];
            _comp.GetPath(i, pathVerts);
            verts.AddRange(pathVerts);
        }

		
    }
}
