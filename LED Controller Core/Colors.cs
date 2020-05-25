namespace LED_Controller_Core
{
    //class for get/set colors and modes
    class Colors
    {
        public (byte, byte, byte) Color { get; set; }

        public int Speed { get; set; }
        public byte Brightness { get; set; }

        public string Normal = "N";
        public string Breath = "B";
        public string Strobe = "S";
        public string Rainbow = "R";
        public string BreathRainbow = "BR";
    }
}
