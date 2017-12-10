/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumGeometry : MonoBehaviour {

	enum shape { triangle, square, rectangle, circle, parallelogram, trapezoid, pentagon }


	[System.Serializable]
		
	class GeometricShapes {
		string name;
		Vector3[] vertices;
		int[] triangle;
		Mesh mesh;
	}

	Mesh meshtri;
	Mesh meshsqu;
	Mesh meshrect;
	Mesh meshcrc;
	Mesh meshpar;
	Mesh meshtrap;
	Mesh meshpent;
		

	Vector3[] verticestri;
	int[] trianglestri;
	Vector3[] verticessqu;
	int[] trianglessqu;
	Vector3[] verticesrect;
	int[] trianglesrect;
	Vector3[] verticescrc;
	int[] trianglescrc;
	Vector3[] verticespar;
	int[] trianglespar;
	Vector3[] verticestrap;
	int[] trianglestrap;
	Vector3[] verticespent;
	int[] trianglespent;


	public void MakeMeshData () {

		verticestri = new Vector3[] { new Vector3 (0, 0, 0), new Vector3 (0, 0, 1.5f), new Vector3 (1.5f, 0, 0) };
		trianglestri = new int[] { 0, 1, 2 };

		verticessqu = new Vector3[] { new Vector3 (0, 0, 0), new Vector3 (0, 0, 1), new Vector3 (1, 0, 0), new Vector3 (1, 0, 1) };
		trianglessqu = new int[] { 0, 1, 2, 0, 2, 3 };

		verticesrect = new Vector3[] { new Vector3 (0, 0, 0), new Vector3 (0, 0, 1), new Vector3 (1.5f, 0, 0), new Vector3 (1.5f, 0, 1) };
		trianglesrect = new int[] { 0, 1, 2, 0, 2, 3 };

		verticescrc = new Vector3[] { new Vector3 (0, 0, 0), new Vector3 (0, 0, 1), new Vector3 (1.5f, 0, 0), new Vector3 (1.5f, 0, 1) };
		trianglescrc = new int[] { 0, 1, 2, 0, 2, 3 };

		verticespar = new Vector3[] { new Vector3 (0, 0, 0), new Vector3 (0, 0, 1), new Vector3 (1, 0, 0), new Vector3 (1, 0, 1), new Vector3 (2, 0, 1) };
		trianglespar = new int[] { 0, 1, 2, 0, 2, 3, 2, 3, 4 };

		verticestrap = new Vector3[] { new Vector3 (0, 0, 0), new Vector3 (0, 0, 1), new Vector3 (1, 0, 0), new Vector3 (1, 0, 1), new Vector3 (2, 0, 2) };
		trianglestrap = new int[] { 0, 1, 2, 0, 2, 3, 2, 3, 4 };

		verticespent = new Vector3[] { new Vector3 (0, 0, 0), new Vector3 (0, 0, 1), new Vector3 (1, 0, 0), new Vector3 (1, 0, 1) };
		trianglespent = new int[] { 0, 1, 2, 0, 2, 3 };

	}

	public void CreateMesh (Mesh mesh, Vector3[] vert, int[] trigl) {
		mesh.Clear ();
		mesh.vertices = vert;
		mesh.triangles = trigl;

	}

	void Update () {

		MakeMeshData ();
		CreateMesh (meshtri, verticestri, trianglestri);
		CreateMesh (meshsqu, verticessqu, trianglessqu);
		CreateMesh (meshrect, verticesrect, trianglesrect);
		CreateMesh (meshcrc, verticescrc, trianglescrc);
		CreateMesh (meshpar, verticespar, trianglespar);
		CreateMesh (meshtrap, verticestrap, trianglestrap);
		CreateMesh (meshpent, verticespent, trianglespent);

	}

}*/