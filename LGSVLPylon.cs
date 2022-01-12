/**
 * Copyright (c) 2021-2022 Gaia Platform LLC
 *
 * This software contains code licensed as described in LICENSE.
 *
 */

using System.Collections.Generic;
using UnityEngine;

namespace Simulator.Controllable
{
    public class LGSVLPylon : MonoBehaviour, IControllable
    {
        public bool Spawned { get; set; }
        public string UID { get; set; }
        public string GUID => UID;
        public string ControlType { get; set; } = "cone";
        public string CurrentState { get; set; }
        public string[] ValidStates { get; set; } = new string[] { };
        public string[] ValidActions { get; set; } = new string[] { };
        public List<ControlAction> DefaultControlPolicy { get; set; } = new List<ControlAction>();
        public List<ControlAction> CurrentControlPolicy { get; set; }

        private void Awake()
        {
            CurrentState = "";
            CurrentControlPolicy = DefaultControlPolicy;
        }

        protected void OnDestroy()
        {
            Resources.UnloadUnusedAssets();
        }

        public void Control(List<ControlAction> controlActions)
        {
        }
    }
}
