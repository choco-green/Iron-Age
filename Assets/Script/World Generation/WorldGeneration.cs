using UnityEngine;

public class WorldGeneration : MonoBehaviour
{
    // [#region ...] is a way of Group code, end with [#endregion]
    #region Integer Variables Declear
    public int Dia;
    public int Layers;

    private const int Length = 1;
    private const int Width = 1;
    private const int Highlayers = -1;
    private const int Layergap = 1;

    #endregion

    #region Float Variables Declear
    private float _probGrass = 0.3f;
    private float _probSand = 0.3f;
    private float _probDirt = 0.3f;
    private float _probStone = 0.1f;
    #endregion

    #region GameObject Variables Declear
    public GameObject Player;
    public GameObject MainMenu;
    public GameObject Quads;
    #endregion

    #region Transform Variables Declear
    public Transform PrefabGrass;
    public Transform PrefabDirt;
    public Transform PrefabSand;
    public Transform PrefabStone;
    #endregion

    #region Material Variables Declear
    public Material MaterialGrass;
    public Material MaterialDirt;
    public Material MaterialSand;
    public Material MaterialStone;
    #endregion

    #region Other Variables Declear

    private readonly System.Random _rnd = new System.Random();
    private CombineMeshes _cm;
    #endregion

    public void WorldGenerating()
    {
        Player.SetActive(true);
        MainMenu.SetActive(false);

        #region World Generation Script
        for (var diameter = 0; diameter < Dia; diameter++)
        {
            for (var diameter2 = 0; diameter2 < Dia; diameter2++)
            {
                for (var x = 0; x < Length; x++)
                {
                    for (var z = 0; z < Width; z++)
                    {
                        for (var layer = 0; layer < Layers; layer++)
                        {
                            var newPrefab = _rnd.Next(1, 11);

                            if (newPrefab == 1 || newPrefab == 2 || newPrefab == 3)
                            {
                                var grass = Instantiate(PrefabGrass, new Vector3
                                    (x + (Length * diameter), // x
                                    (Highlayers - layer / Layergap), // y
                                    z + diameter2 * Width), // z
                                    Quaternion.identity);
                                grass.transform.parent = Quads.transform;
                            }
                            else if (newPrefab == 4 || newPrefab == 5 || newPrefab == 6)
                            {
                                var sand = Instantiate(PrefabSand, new Vector3
                                    (x + (Length * diameter), // x
                                        (Highlayers - layer / Layergap), // y
                                        z + diameter2 * Width), // z
                                    Quaternion.identity);
                                sand.transform.parent = Quads.transform;
                            }
                            else if (newPrefab == 7 || newPrefab == 8 || newPrefab == 9)
                            {
                                var dirt = Instantiate(PrefabDirt, new Vector3
                                    (x + (Length * diameter), // x
                                        (Highlayers - layer / Layergap), // y
                                        z + diameter2 * Width), // z
                                    Quaternion.identity);
                                dirt.transform.parent = Quads.transform;
                            }
                            else if (newPrefab == 10)
                            {
                                var stone = Instantiate(PrefabStone, new Vector3
                                    (x + (Length * diameter), // x
                                        (Highlayers - layer / Layergap), // y
                                        z + diameter2 * Width), // z
                                    Quaternion.identity);
                                stone.transform.parent = Quads.transform;
                            }
                        }
                    }
                }
            }
        }
        //Combine();
        #endregion

        /*
        for (int diameter = 0; diameter < dia; diameter++)
        {
            for (int diameter2 = 0; diameter2 < dia; diameter2++)
            {
                for (int x = 0; x < Length; x++)
                {
                    for (int z = 0; z < Width; z++)
                    {
                        Instantiate(PrefabWater, new Vector3(x + (Length * diameter), highlayers - (layers * layergap), z + diameter2 * Width), Quaternion.identity);                
                    }
                }
            }
        }
        */
    }

    /*
    public void Combine()
    {
        //1. Combine All Children meshes
        MeshFilter[] meshFilters = Quads.GetComponentsInChildren<MeshFilter>();
        CombineInstance[] combine = new CombineInstance[meshFilters.Length];
        //Debug.Log(name + " is combining " + meshFilters.Length + " meshes");

        int i = 0;
        while(i < meshFilters.Length)
        {
            combine[i].mesh = meshFilters[i].sharedMesh;
            combine[i].transform = meshFilters[i].transform.localToWorldMatrix;
            i++;
        }

        //2. Create a new mesh in the "Quads" Game Object
        MeshFilter MF = (MeshFilter)Quads.gameObject.AddComponent(typeof(MeshFilter));
        MF.mesh = new Mesh();

        //3. COMBINE COMBINE COMBINE!!!!!!!!
        MF.mesh.CombineMeshes(combine);

        //4. Create a renderer for the "Quads"
        MeshRenderer renderer = Quads.gameObject.AddComponent(typeof(MeshRenderer)) as MeshRenderer;
        renderer.material = MaterialDirt;

        //5. Delete all uncombine children
        foreach(Transform Quad in Quads.transform)
        {
            Destroy(Quad.gameObject);
        }
    }
    */
}