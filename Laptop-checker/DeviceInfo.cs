using System;
using System.Collections.Generic;
using System.Text;

namespace Laptop_checker
{
    public class DeviceInfo
    {
        public string DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public string CPU { get; set; }
        public string RAM { get; set; }
        public string GPU { get; set; }
        public string Storage { get; set; }

        public string WindowsVersion { get; set; }
    }
}
