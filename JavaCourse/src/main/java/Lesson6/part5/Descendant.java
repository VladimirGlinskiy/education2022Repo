package Lesson6.part5;

import java.io.IOException;

public class Descendant extends Main {

  public static void main(String[] args) throws IOException {
    Descendant descendant = new Descendant();
    descendant.getUserInfo();

    Main main = new Main();
    main.getUserInfo();
  }

  @Override
  void getUserInfo() throws IOException {
    System.out.println("Введите вашу фамилию");
    String result = String.format("Возможно, ваша фамилия \"%s\"", reader());
    System.out.println(result);
  }
}
