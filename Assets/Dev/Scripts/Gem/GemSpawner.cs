using UnityEngine;

public class GemSpawner : MonoBehaviour
{
    public GemDatabase gemDatabase;
    GameObject instantiateGem;
    Grid grid;
    GameObject spawnedGem;

    private void Start()
    {
        grid = GameObject.FindWithTag("Grid").GetComponent<Grid>(); 
    }

    private void Update()
    {
        InstantiateGem();
    }

    private void RandomGem()
    {
        int randomGem= Random.Range(0, gemDatabase.gems.Count);
        instantiateGem = gemDatabase.gems[randomGem].gemPrefab;
    }

    public void InstantiateGem()
    {

        foreach (Transform gridBlock in grid.transform)
        {
            if (gridBlock.childCount==0)
            {
                RandomGem();
                Vector3 position =new Vector3(gridBlock.position.x,gridBlock.position.y + 0.51f,gridBlock.position.z);
                spawnedGem=Instantiate(instantiateGem, position, Quaternion.identity,gridBlock);
                spawnedGem.transform.localScale = new Vector3(0.2f, 4f, 0.2f);
            }
        }
    }

}
