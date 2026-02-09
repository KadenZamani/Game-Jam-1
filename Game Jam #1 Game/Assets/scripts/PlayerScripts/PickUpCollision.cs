using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TranslateMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] AudioSource audioSource;
    public TextMeshProUGUI scoreText;
    [SerializeField] private int targetScore;
    private int scoreCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreCount = 0;
        scoreText.text = "Mushrooms: " + scoreCount + "/30";
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreCount >= targetScore)
        {
            SceneManager.LoadScene(4);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            scoreCount = scoreCount + 1;
            scoreText.text = "Mushrooms: " + scoreCount + "/30";
            audioSource.Play();
        }
    }
}
