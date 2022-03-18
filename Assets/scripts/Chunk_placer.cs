using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk_placer : MonoBehaviour
{
	public Transform player;
	public Chunk[] ChunkPrefabs;
	public Chunk FirstChunk;

	private List<Chunk> spawnedChunks = new List<Chunk>();
    // Start is called before the first frame update
    void Start()
    {
        spawnedChunks.Add(FirstChunk);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (player.position.y > spawnedChunks[spawnedChunks.Count-1].End.position.y) {
        	SpawnChunk();
        }
    }
    private void SpawnChunk() {
    	Chunk newChunk = Instantiate(ChunkPrefabs[Random.Range(0, ChunkPrefabs.Length)]);
    	newChunk.transform.position = spawnedChunks[spawnedChunks.Count-1].End.position - newChunk.Begin.localPosition;
    	//newChunk.transform.position.x = spawnedChunks[spawnedChunks.Count-1].End.position.x - newChunk.Begin.localPosition.x;
    	spawnedChunks.Add(newChunk);
    }
}
