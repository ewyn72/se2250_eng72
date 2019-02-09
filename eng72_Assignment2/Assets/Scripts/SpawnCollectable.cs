using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCollectable : MonoBehaviour
{
	public GameObject cubePrefabVar;
	private GameObject cube;
    public int numOfObjects;
    public float radius;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numOfObjects; i++) {
            float angle = i * Mathf.PI * 2f / numOfObjects;
            Vector3 newPos = new Vector3(Mathf.Cos(angle) * radius, 0.9f, Mathf.Sin(angle) * radius);
            cube = Instantiate(cubePrefabVar, newPos, Quaternion.identity);
            Renderer collectableRenderer = cube.GetComponent<Renderer>();
            ChangeMaterial(collectableRenderer);
        }
    }

    void ChangeMaterial(Renderer cubeRenderer)
    {
        Color color = new Color();
        switch (Random.Range(0, 4))
        {
            case 0:
                color = Color.yellow;
                break;
            case 1:
                color = Color.blue;
                break;
            case 2:
                color = Color.red;
                break;
            case 3:
                color = Color.green;
                break;
            case 4:
                color = Color.white;
                break;
        }
        cubeRenderer.material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
