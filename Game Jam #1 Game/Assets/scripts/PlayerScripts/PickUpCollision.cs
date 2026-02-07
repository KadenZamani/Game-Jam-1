using UnityEngine;
using TMPro;

public class TranslateMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] AudioSource audioSource;
    public TextMeshProUGUI scoreText;
    private int scoreCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreCount = 0;
        scoreText.text = "Score: " + scoreCount;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            scoreCount = scoreCount + 1;
            scoreText.text = "Score: " + scoreCount;
            audioSource.Play();
        }
    }
}
