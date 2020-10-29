# include <SPI.h>
# include <Wire.h>
# include <Adafruit_GFX.h>
# include <Adafruit_SSD1306.h>
# include "SenseBoxMCU.h"
    
# define OLED_RESET 4
Adafruit_SSD1306 display(OLED_RESET);


void setup() {
    // init snake
    boolean continue = true;
    boolean button_pressed = false;
    Snake snake = new Snake();
    // TODO what does this do
    pinMode(7, OUTPUT);
    digitalWrite(7,HIGH);
    // init time
    int time = millis();
    String[] DIRECTIONS = new String[] {"right", "left", "up", "down"};
    // display setup
    senseBoxIO.powerI2C(true);
    delay(2000);
    display.begin(SSD1306_SWITCHCAPVCC, 0x3D);
    display.display();
    delay(100);
    display.clearDisplay();
}

void loop() {
    continue = useSensorInput(continue);
    if (millis() - time > 500 && continue){
      snake.move();
      time = millis();
    }

}

public boolean useSensorInput() {
    String dir;
    // sensor input kontrollieren
    snake.setDirection(dir);

    return continue;
}

public class Snake{
    public Snake() {
      int[] coord = new int[] {15, 15};
      SnakeSegment[] coords = new SnakeSegment[];
      String directionHeading = "right";
    }
    public void move(){
      switch (directionHeading) {
          case "right":
              coord[0] += 1;
          case "left":
              coord[0] -= 1;
          case "up":
              coord[1] += 1;
          case "down":
              coord[1] += 1;
          default:
              break;
      }
    }
    public void show(){
        // fillRect(x, y, width, height, full(bool))
        display.fillRect();
        display.display();
    }
    public void setDirection(dir) {
      direction = dir;
    }
}
public class SnakeSegment {
}
