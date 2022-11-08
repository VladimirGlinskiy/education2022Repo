package Lesson6.part2;

public class AbstractClasses {

  public static void showInformation(Employee employee) {
    employee.showAllInformation();
    employee.greetingOfPerson();
  }

  public static void showInformation(Customer customer) {
    customer.showAllInformation();
    customer.greetingOfPerson();
  }

  public static void showInformation(Stranger stranger) {
    stranger.showAllInformation();
    stranger.greetingOfPerson();
  }

  public static void main(String[] args) {
    showInformation(new Customer("Joseph", "Brodskij", "Bank of New-York"));
    System.out.println("--separator--");
    showInformation(new Employee("Franz", "Kafka", "Bank of Berlin"));
    System.out.println("--separator--");
    showInformation(new Stranger("Leonid", "Filatov", false));

  }

  static class Customer extends Person {

    String banksName;

    public Customer(String firstName, String lastname, String banksName) {
      super(firstName, lastname);
      this.banksName = banksName;
    }

    @Override
    public void showAllInformation() {
      System.out.println(String
          .format("First name: %s.\nLast name: %s.\nBank name: %s", firstName, lastname,
              banksName));
    }

    @Override
    public void greetingOfPerson() {
      System.out.println("Welcome, we are glad to see our client!");
    }
  }

  static class Employee extends Person {

    String banksName;

    Employee(String firstName, String lastname, String banksName) {
      super(firstName, lastname);
      this.banksName = banksName;
    }

    @Override
    public void showAllInformation() {
      System.out.println(String
          .format("First name: %s.\nLast name: %s.\nBank name: %s", firstName, lastname,
              banksName));
    }

    @Override
    public void greetingOfPerson() {
      System.out.println("I'm glad to see you at work!");
    }
  }

  static class Stranger extends Person {

    boolean callToPolise;

    Stranger(String firstName, String lastname, boolean callToPolise) {
      super(firstName, lastname);
      this.callToPolise = callToPolise;
    }

    @Override
    public void showAllInformation() {
      System.out.println(String
          .format("First name: %s.\nLast name: %s.\nCall to police? -%s", firstName, lastname,
              callToPolise));
    }

  }

}
