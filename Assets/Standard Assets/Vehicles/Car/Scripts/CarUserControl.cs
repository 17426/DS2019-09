using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        [SerializeField] private float v;
        [SerializeField] private float v1;
        [SerializeField] private float footbrake;
        [SerializeField] private float h1;
        [SerializeField] private float h;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
             h1 = CrossPlatformInputManager.GetAxis("Horizontal");
            if( -0.35f > h1 || h1 < 0.35f)
            {
                h = h1 * 1.8f;
            }
             v1 = CrossPlatformInputManager.GetAxis("Vertical");

            v = (v1 + 0.99f) / 2.0f;

            footbrake = v1 * 0.0005f;

            

#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");

            



            m_Car.Move(h, v, footbrake, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
    }
}

