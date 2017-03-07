using UnityEngine;

public class Team_Credits : MonoBehaviour
{
    private AudioManager _audioManager;
    private Metrics _metrics;
    private Animation _fadeAnim;
    private Animation _creditAnim;

	bool dispCredits = false;
	public GameObject Fade;
	public GameObject Credit;

    private void Start()
    {
        _audioManager = AudioManager.GetInstance();
        _metrics = Metrics.GetInstance();
        _fadeAnim = Fade.GetComponent<Animation>();
        _creditAnim = Credit.GetComponent<Animation>();
    }

    public void Clicked ()
	{
        _metrics.OpenedCredits();

        _audioManager.PlaySoundAtPosition ("SmallPok", gameObject, false);

		if (dispCredits == false) {
			dispCredits = true;
			_fadeAnim.Play ("Fade_In_Credits_Anim");
			_creditAnim.Play ("Team_Credits_In_Anim");
			Fade.SetActive (true);
		} else if (dispCredits == true) {
			dispCredits = false;
			_fadeAnim.Play ("Fade_Out_Credits_Anim");
			_creditAnim.Play ("Team_Credits_Out_Anim");
			Fade.SetActive (false);
		}
	}
}
