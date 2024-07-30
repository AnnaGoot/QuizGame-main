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
        [SerializeField] private Vector3 shakeStrength = new Vector3(1.0f, 0.0f, 0.0f) ;
        [SerializeField] private int shakeVibration = 30;
        [SerializeField] private float elasticity = 1f;

        public void Notify(bool correct)
        {
            if (!use || correct)
            {
                return;
            }

            transform.DOKill();
            transform.DOPunchPosition(shakeStrength, shakeDuration, shakeVibration, elasticity);
        }

    }
}