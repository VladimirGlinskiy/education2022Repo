package Lesson6.part2;

public interface Showable {

  void showAllInformation();

  default void greetingOfPerson() {
    System.out.println("Hello, are you a newbie?");
  }
}
