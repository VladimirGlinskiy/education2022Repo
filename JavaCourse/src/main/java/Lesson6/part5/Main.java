package Lesson6.part5;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {

  String reader() throws IOException {
    BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
    return br.readLine();
  }

  void getUserInfo() throws IOException {
    System.out.println("Введите ваш возраст");
    String str = String.format("Возможно, ваш возраст \"%s\"", reader());
    System.out.println(str);
  }

}
