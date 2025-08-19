using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciadorDeCena : MonoBehaviour
{
    public string cenaNome;

    public void MudarCena()
    {
        SceneManager.LoadScene(cenaNome);
    }
    public void Sair()
    {
        Application.Quit();
    }
}