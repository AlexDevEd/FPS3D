using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPS.Controller
{
    public class FlashlightController : BaseController
    {
        private Light _light;

        private void Awake()
        {
            _light = GameObject.Find("FlashLight").GetComponent<Light>();
        }

        private void Start()
        {
            SetActiveFlashLight(false);
        }
        private void Update()
        {
            if (!Enabled) return;
        }

        private void SetActiveFlashLight(bool value)
        {
            _light.enabled = value;
        }

        public override void On()
        {
            if(Enabled) return;
            base.On();
            SetActiveFlashLight(true);
        }
        public override void Off()
        {
            if (!Enabled) return;
            base.Off();
            SetActiveFlashLight(false);
        }




    }
}
