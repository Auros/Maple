﻿using IPA;
using IPALogger = IPA.Logging.Logger;

namespace Maple
{
    [Plugin(RuntimeOptions.DynamicInit)]
    public class Plugin
    {
        [Init]
        public Plugin(IPALogger _)
        {

        }

        [OnEnable]
        public void OnEnable()
        {

        }

        [OnDisable]
        public void OnDisable()
        {

        }
    }
}