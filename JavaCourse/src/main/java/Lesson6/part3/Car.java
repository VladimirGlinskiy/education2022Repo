package Lesson6.part3;

public class Car {

  public int weight;
  public String model;
  public char color;
  public float speed;


  public Car(int w, String m, char c, float s) {
    weight = w;
    model = m;
    color = c;
    speed = s;
  }

  public Car() {
  }

  public void outPut() {
    System.out.println("Вес " + model + " составляет " + weight + "кг.");
    System.out.println("Цвет машины - " + color + " и её скорость - " + speed);
  }
}
