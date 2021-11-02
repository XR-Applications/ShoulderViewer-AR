using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingCubeBehaviour : MonoBehaviour
{
    [SerializeField] GameObject loadingText;
    [SerializeField] float xRotSpeed = 4f;
    [SerializeField] float yRotSpeed = 4f;
    [SerializeField] float zRotSpeed = 4f;

    private void Awake()
    {
        loadingText.SetActive(false);
    }
    public void LoadChosenScene(int index)
    {
        loadingText.SetActive(true);
        SceneManager.LoadSceneAsync(index);
    }

    IEnumerator StartLoadSequence(int index)
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadSceneAsync(index);

    }
    private void Update()
    {
        transform.Rotate(xRotSpeed * Time.deltaTime,
            yRotSpeed * Time.deltaTime,
            zRotSpeed * Time.deltaTime);
    }
}
