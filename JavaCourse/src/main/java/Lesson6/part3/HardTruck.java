package Lesson6.part3;

public class HardTruck extends Car {

  public int numberOfWheels;
  public int maxWeight;

  HardTruck(int weight, String model, char color, float speed, int numberOfWheels, int maxWeight) {
    super(weight, model, color, speed);
    this.maxWeight = maxWeight;
    this.numberOfWheels = numberOfWheels;
  }

  public static void main(String[] args) {
    HardTruck hardTruck = new HardTruck(15000, "The Best", "Black".charAt(0), 70, 12, 10000);
    hardTruck.outPut();
    hardTruck.newWeels(30);
  }

  void newWeels(int newNumberOfWheels) {
    numberOfWheels = newNumberOfWheels;
    System.out.println("New number of wheels is" + numberOfWheels);
  }
}


