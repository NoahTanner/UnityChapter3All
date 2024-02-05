using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    private GameObject _enemy;
    public float minScaleMultiplier = 0.8f;
    public float maxScaleMultiplier = 1.2f;
    public Renderer enemyRenderer;
    

    // Start is called before the first frame update
    void Start()
    {
        enemyRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_enemy == null)
        {
            _enemy = Instantiate(enemyPrefab) as GameObject;
            Color newColor = new Color(Random.value, Random.value, Random.value);
            enemyRenderer.material.color = newColor;
            _enemy.transform.position = new Vector3(0, 1, 0);
            float scaleFactor = Random.Range(minScaleMultiplier, maxScaleMultiplier);
            _enemy.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y * scaleFactor, transform.localScale.z);
            float angle = Random.Range(0, 360);
            _enemy.transform.Rotate(0,angle,0);
        }
    }
}
