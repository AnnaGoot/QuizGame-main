using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace View
{
    [RequireComponent(typeof(Button))]
    public class ShakeFailButton : MonoBehaviour, IButtonEffect
    {
        [SerializeField] private bool use = true;
        [SerializeField] private float shakeDuration = 0.5f;
        [SerializeField] private float shakeStrength = 10f;
        [SerializeField] private int shakeVibration = 30;
        [SerializeField] private float shakeRandom = 50f;
        private Tween currentTween;

        public void Notify(bool correct)
        {
            if (!use || correct)
            {
                return;
            }

            transform.DOKill();
            currentTween = transform.DOShakePosition(shakeDuration, shakeStrength, shakeVibration, shakeRandom);
        }

    }
}