void setup() {
    boolean continue = true;
    boolean button_pressed = false;
    Snake snake = new Snake();
    pinMode(7, OUTPUT);
    digitalWrite(7,HIGH);
    int time = millis();

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
      String direction = "right";
    }
    public void move(){
      switch (direction) {
          case "right":
              coord[0] += 1;
          case "left":
              coord[0] -= 1;
          case "up":
              coord[1] += 1;
          case "down":
              coord[1] += 1;
      }
    }
    public void show(){

    }
    public void setDirection(dir) {
      direction = dir;
    }
}
