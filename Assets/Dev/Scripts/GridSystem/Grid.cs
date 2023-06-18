using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public int rows;
    public int columns;
    public float spacing;
    [SerializeField] GameObject gridBlockPrefab;
    public Transform parentTransform;
    private void Awake()
    {
        GenerateGrid();
    }

#if UNITY_EDITOR
    [ContextMenu("Generate Grid")]
    private void GenerateGrid()
    {
        ClearGrid();

        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                Vector3 position = new Vector3(transform.position.x + row * (1 + spacing), 0,transform.position.z + column * (1 + spacing));
                GameObject gridBlock = Instantiate(gridBlockPrefab, position, Quaternion.identity, transform);
                gridBlock.name = string.Format("GridBlock({0},{1})", row, column);
            }
        }
    }

    private void ClearGrid()
    {
        int childCount = transform.childCount;
        for (int i = childCount - 1; i >= 0; i--)
        {
            DestroyImmediate(transform.GetChild(i).gameObject);
        }
    }
#endif
}

