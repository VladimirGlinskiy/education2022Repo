package Lesson7;

public class Main {

  public static void main(String[] args) {

    Plane bombardier = new Plane();
    Plane.Wing bombardierWing = bombardier.new Wing();

    Plane airbus = new Plane();
    Plane.Wing airBuswing = airbus.new Wing();

    bombardierWing.setWingWeight(300);
    airBuswing.setWingWeight(200);

    System.out.println("Вес крыла самолета Бомбардье : " + bombardierWing.getWingWeight());
    System.out.println("Вес крыла самолета Эйрбас : " + airBuswing.getWingWeight());
  }
}
