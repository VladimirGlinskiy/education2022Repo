package Lesson6;

public class AbstractClasses {

    static class Customer extends Person {

        String banksName;

        @Override
        void showAllInformation() {
            System.out.println(String.format("First name: %s.\nLast name: %s.\nBank name: %s", firstName, lastname, banksName));
        }

        public Customer(String firstName, String lastname, String banksName) {
            super(firstName, lastname);
            this.banksName = banksName;
        }
    }

    static class Employee extends Person {

        String banksName;

        Employee(String firstName, String lastname, String banksName) {
            super(firstName, lastname);
            this.banksName = banksName;
        }

        @Override
        void showAllInformation() {
            System.out.println(String.format("First name: %s.\nLast name: %s.\nBank name: %s", firstName, lastname, banksName));
        }
    }

    public static void showInformation(Employee employee) {
        employee.showAllInformation();
    }

    public static void showInformation(Customer customer) {
        customer.showAllInformation();
    }

    public static void main(String[] args) {
        showInformation(new Customer("Joseph", "Brodskij", "Bank of New-York"));
        System.out.println("--separator--");
        showInformation(new Employee("Franz", "Kafka", "Bank of Berlin"));
    }

}
