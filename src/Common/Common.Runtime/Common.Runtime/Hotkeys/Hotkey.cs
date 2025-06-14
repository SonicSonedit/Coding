﻿namespace Common.Runtime.Hotkeys
{
    public class Hotkey
    {
        public Key Key { get; init; }
        public KeyModifiers KeyModifiers { get; init; }
        public UniversalKey PhysicalKey { get; init; }
        public string KeySymbol { get; init; }
        public KeyDeviceType KeyDeviceType { get; init; }
    }
}
