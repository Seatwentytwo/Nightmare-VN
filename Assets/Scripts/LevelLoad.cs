using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    public string SceneName;
    public bool Locked;

    public GameObject RequiredItem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Locked == true)
        {
            Locked = RequiredItem.GetComponent<Inventory>().KeyCollected;
            Locked = !Locked;
        }

        if (collision.gameObject.name == "Player" && Locked == false)
        {
            SceneManager.LoadScene(SceneName);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneName);
    }
}
