using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MeshFilter))]
public class shapeGenerator : MonoBehaviour {


	/*
	 * Mesh mesh;
	Material mat;
	Vector3[] vertices;
	int[] triangles;
	Vector3[] vertices1;
	int[] triangles1;
	Vector3[] vertices2;
	int[] triangles2;
	*/

	Color black = new Color(0, 0, 0, 1);
	Color white = new Color(1, 1, 1, 1);
	Color[] colors;
	Color[] colors2;

	Mesh meshtri;

	Mesh meshtri2;

	Mesh meshsqu;
	Mesh meshrect;
	Mesh meshcrc;
	Mesh meshpar;
	Mesh meshtrap;
	Mesh meshpent;


	Vector3[] verticestri;
	int[] trianglestri;

	Vector3[] verticestri2;
	int[] trianglestri2;

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



	private RandomBall rb;
	private int cb;

	void Awake () {
		meshtri = GetComponent<MeshFilter> ().mesh;

		meshtri2 = GetComponent<MeshFilter> ().mesh;
			

		meshsqu = GetComponent<MeshFilter> ().mesh;
		meshrect = GetComponent<MeshFilter> ().mesh;
		meshcrc = GetComponent<MeshFilter> ().mesh;
		meshpar = GetComponent<MeshFilter> ().mesh;
		meshtrap = GetComponent<MeshFilter> ().mesh;
		meshpent = GetComponent<MeshFilter> ().mesh;
	}

	// Use this for initialization

	void Start () {
		MakeMeshData ();
		//CreateMesh (vertices1, triangles1);
		rb = new RandomBall ();
	}

	void MakeMeshData () {
		/*vertices = new Vector3[] { new Vector3 (0, 0, 0), new Vector3 (0, 0, 0.5f), new Vector3 (0.5f, 0, 0), new Vector3 (0.5f, 0, 0.5f) };
		triangles = new int[] { 0, 1, 2, 1, 2, 3 };

		vertices1 = new Vector3[] { new Vector3 (0, 0, 0), new Vector3 (0, 0, -1), new Vector3 (-1, 0, 0), new Vector3 (-1, 0, -1) };
		triangles1 = new int[] { 0, 1, 2, 1, 2, 3 };

		vertices2 = new Vector3[] { new Vector3 (0, 0, 0), new Vector3 (0, 0, 1), new Vector3 (1, 0, 0), new Vector3 (1, 0, 1) };
		triangles2 = new int[] { 0, 1, 2, 0, 2, 3 };*/



		verticestri = new Vector3[] { new Vector3 (0.5f, 1, 0.5f), new Vector3 (0.5f, 1, 1), new Vector3 (1, 1, 0.5f) };
		trianglestri = new int[] { 0, 1, 2 };


		verticestri2 = new Vector3[] { new Vector3 (0, 0, 0), new Vector3 (0, 0, 1.5f), new Vector3 (1.5f, 0, 0) };
		trianglestri2 = new int[] { 0, 1, 2 };


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
	/*
	void CreateMesh (Vector3[] v, int[] t) {
		mesh.Clear ();
		mesh.vertices = v;
		mesh.triangles = t;
	}
*/
	void CreateMesh8 (Mesh mesh, Mesh mesh2, Vector3[] vert, Vector3[] vert2, int[] trigl, int[] trigl2, Color color, Color color2 ) {
		mesh.Clear ();
		mesh2.Clear ();

		mesh.vertices = vert;
		mesh2.vertices = vert2;

		mesh.triangles = trigl;
		mesh2.triangles = trigl2;

		colors = new Color[vert.Length];
		colors2 = new Color[vert2.Length];

		for (int i = 0; i < vert.Length; i++) 
			colors[i] = color;

		for (int i = 0; i < vert2.Length; i++) 
			colors2[i] = color2;

		
		mesh.colors = colors;
		mesh2.colors = colors2;

	}

	void CreateMesh4 (Mesh mesh, Vector3[] vert, int[] trigl, Color color) {
		mesh.Clear ();
		mesh.vertices = vert;
		mesh.triangles = trigl;

		colors2 = new Color[vert.Length];

		for (int i = 0; i < vert.Length; i++) 
			colors2[i] = color;


		mesh.colors = colors2;


	}

	void Update () {

		cb = rb.GetCountBall ();

		switch (cb) {

		case 2:
			
			CreateMesh8 (meshtri, meshtri2, verticestri, verticestri2, trianglestri, trianglestri2, black, white);
			//CreateMesh4 (meshtri, verticestri, trianglestri, black);
			break;

		case 4:
			meshtri.Clear ();
			CreateMesh4 (meshsqu, verticessqu, trianglessqu, white);
			break;
		case 6:
			meshsqu.Clear ();
			CreateMesh4 (meshrect, verticesrect, trianglesrect, white);
			break;
		case 8:
			meshrect.Clear ();
			CreateMesh4 (meshcrc, verticescrc, trianglescrc, white);
			break;
		case 10:
			meshcrc.Clear ();
			CreateMesh4 (meshpar, verticespar, trianglespar, white);
			break;
		case 12:
			meshpar.Clear ();
			CreateMesh4 (meshtrap, verticestrap, trianglestrap, white);
			break;
		case 14:
			meshtrap.Clear ();
			CreateMesh4 (meshpent, verticespent, trianglespent, white);
			break;
		}
	}
}
