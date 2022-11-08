package Lesson6.part4;

public class Child extends Parent {


  public static void main(String[] args) {
    Child child = new Child();
    System.out.println(child.getAnothernumber());

    child.getValue();
    child.setNumber(33);
    child.getValue();

  }

  void getValue() {
    System.out.println(getNumber());
  }

}
