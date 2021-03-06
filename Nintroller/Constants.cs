﻿namespace NintrollerLib
{
    // TODO: Place any magic numbers in this class
    internal static class Constants
    {
        // Vendor ID (Nintendo) & Product IDs
        public const int VID    = 0x057e;
        public const int PID1   = 0x0306;       // Legacy Wiimotes
        public const int PID2   = 0x0330;       // Newer Wiimotes (And Pro Controllers)
        public const int PID3   = 0x0337;       // GCN Adapter

        // Report Size, There are several reports to choose from
        public const int REPORT_LENGTH = 22;   // Buttons, Accelerometer, IR, and Extension
        public const int REPORT_LENGTH_GCN = 37;

        // Wiimote Registers
        public const int REGISTER_IR = 0x04b00030;
        public const int REGISTER_IR_SENSITIVITY_1 = 0x04b00000;
        public const int REGISTER_IR_SENSITIVITY_2 = 0x04b0001a;
        public const int REGISTER_IR_MODE = 0x04b00033;
        public const int REGISTER_EXTENSION_INIT_1 = 0x04a400f0;
        public const int REGISTER_EXTENSION_INIT_2 = 0x04a400fb;
        public const int REGISTER_EXTENSION_TYPE = 0x04a400fa;
        public const int REGISTER_EXTENSION_TYPE_2 = 0x04a400fe;
        public const int REGISTER_EXTENSION_CALIBRATION = 0x04a40020;
        
        // Write 0x04 to this register to init motion plus
        public const int REGISTER_MOTIONPLUS_INIT = 0x04a600fe;
        // Read 2 bytes from here to identify if motion plus connected
        public const int REGISTER_MOTIONPLUS = 0x04A600FE;
        // Write 0x55 to initialze motion plus's extiontion
        public const int REGISTER_MOTIONPLUS_EXT = 0x04A600F0;

        // Length and Width between Balance Board Sensors
        public const int BB_LENGTH = 43;
        public const int BB_WIDTH = 24;

        // Pound - KG Conversion
        public const float KG_TO_LBS = 2.20462262f;
    }
}
