using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPS3D.Controllers
{
    public abstract class BaseController : MonoBehaviour
    {
        private bool _enabled = false;

        public bool Enabled
        {
            get => _enabled;
            private set => _enabled = value;
        }

        public virtual void On()
        {
            _enabled = true;
        }
        public virtual void Off()
        {
            _enabled = false;
        }
    }
}
