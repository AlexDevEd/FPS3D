using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPS.Controller
{
    public class InputController : BaseController
    {
        private bool _isActiveFlashlight = false;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                _isActiveFlashlight = !_isActiveFlashlight;
                if (_isActiveFlashlight)
                    Main.Instance.GetFlashlightController().On();
                else
                    Main.Instance.GetFlashlightController().Off();

            }
        }
    }
}
