using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
    public Slider progressBar;
    public TextMeshProUGUI progressText;
    public float progressTime;

    public void Play(UnityAction action = null)
    {
        StartCoroutine(OnProgress(action));
    }

    IEnumerator OnProgress(UnityAction action)
    {
        float curr = 0.0f;
        float percent = 0.0f;

        while (percent < 1.0f)
        {
            curr += Time.deltaTime;
            percent = curr / progressTime;

            progressText.text = $"Now Loading.. {progressBar.value * 100:F0}%";
            progressBar.value = Mathf.Lerp(0, 1, percent);

            yield return null;
        }
        
        action?.Invoke();
    }
}
