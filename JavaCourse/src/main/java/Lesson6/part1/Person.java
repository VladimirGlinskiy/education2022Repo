package Lesson6.part1;

public abstract class Person {

  public String firstName;
  public String lastname;

  Person(String firstName, String lastname) {
    this.firstName = firstName;
    this.lastname = lastname;
  }

  public String getFirstName() {
    return firstName;
  }

  public String getLastname() {
    return lastname;
  }

  abstract void showAllInformation();
}

