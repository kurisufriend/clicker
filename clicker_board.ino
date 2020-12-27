#include "Mouse.h"

#define SERIAL_SPEED 9600

void setup()
{
  //Mouse.begin();
  Serial.begin(SERIAL_SPEED);
  delay(2000);
  Serial.println("hello");
}

void loop()
{
  if (Serial.available())
  {
    char input = (char)Serial.read();
    Serial.print("poo");
    if (input)
    {
      Mouse.click();
    }
  }
}
