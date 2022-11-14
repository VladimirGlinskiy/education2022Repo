package Lesson6.part4;

import java.util.Scanner;

public class Child extends Parent {


  public static void main(String[] args) {
    Child child = new Child();

    System.out.println(child.getAnothernumber());
    child.getNumber();

    System.out.println("Задайте значение: ");
    Scanner in = new Scanner(System.in);

    child.setNumber(in.nextInt());
    child.getNumber();
  }

  @Override
  public int getNumber() {
    int res = super.getNumber();
    System.out.println(res);
    return res;
  }

}
