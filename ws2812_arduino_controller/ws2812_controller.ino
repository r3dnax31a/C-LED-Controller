#include <Adafruit_NeoPixel.h>
 
#define PIN            2
#define NUMPIXELS      26
 
Adafruit_NeoPixel pixels = Adafruit_NeoPixel(NUMPIXELS, PIN, NEO_GRB + NEO_KHZ800);
 
//int delayval = 100;
int led = 2;
int R;
int G;
int B;


void setup()
{
  Serial.begin(9600);
  Serial.setTimeout(50);
  pixels.begin();
  pinMode(led, OUTPUT);
}

void loop()
{
  if (Serial.available() > 0)
    {
      String buffString = Serial.readString();
      byte dividerIndexOne = buffString.indexOf('A');
      byte dividerIndexTwo = buffString.indexOf('B');
      String buffR = buffString.substring(0, dividerIndexOne);
      String buffG = buffString.substring(dividerIndexOne + 1);
      String buffB = buffString.substring(dividerIndexTwo + 1);

      R = buffR.toInt();
      G = buffG.toInt();
      B = buffB.toInt();
    }

  for(int i=0;i<NUMPIXELS;i++){

    pixels.setPixelColor(i, pixels.Color(R,G,B)); // Moderately bright green color.

    pixels.show(); // This sends the updated pixel color to the hardware.

   // delay(delayval); // Delay for a period of time (in milliseconds).
}
}
