public class Lesson2 {

    static class Calculator {

        Double summator(Double firstNumber, Double secondNumber) {
            return firstNumber + secondNumber;
        }

        Double division(Double firstNumber, Double secondNumber) {
            return firstNumber / secondNumber;
        }

        Double multiplication(Double firstNumber, Double secondNumber) {
            return firstNumber * secondNumber;
        }

        Double substraction(Double firstNumber, Double secondNumber) {
            return firstNumber - secondNumber;
        }


        long summator(long firstNumber, long secondNumber) {
            return firstNumber + secondNumber;
        }

        double division(long firstNumber, long secondNumber) {
            return (double) firstNumber / secondNumber;
        }

        long multiplication(long firstNumber, long secondNumber) {
            return firstNumber * secondNumber;
        }

        long substraction(long firstNumber, long secondNumber) {
            return firstNumber - secondNumber;
        }


        int summator(int firstNumber, int secondNumber) {
            return firstNumber + secondNumber;
        }

        double division(int firstNumber, int secondNumber) {
            return (double) firstNumber / secondNumber;
        }

        int multiplication(int firstNumber, int secondNumber) {
            return firstNumber * secondNumber;
        }

        int substraction(int firstNumber, int secondNumber) {
            return firstNumber - secondNumber;
        }

    }

    static class Gnome {

        String gnomesName;
        boolean isEating;
        boolean isSleeping;
        boolean isDrinkingWine;
        int gnomesAge;

        public Gnome(String name) {
            this.gnomesName = name;
            this.gnomesAge = 101;
        }

        public Gnome(String name, boolean eatingStatus, boolean sleepingStatus, boolean drinkingWineStatus, int age) {
            this.gnomesName = name;
            this.isEating = eatingStatus;
            this.isSleeping = sleepingStatus;
            this.isDrinkingWine = drinkingWineStatus;
            this.gnomesAge = age;
        }

        public void getClassValues() {
            System.out.println("\n The gnomes name is: " + gnomesName + "\n The gnome is " + gnomesAge + " years old" + "\n Is gnome eating: " + isEating +
                    "\n Is gnome sleeping: " + isSleeping + "\n Is gnome drinking the wine : " + isDrinkingWine);
        }

    }

    public static void main(String... args) {

        // Проверяем методы класса "Калькулятор"

        Calculator calc = new Calculator();

        Double a = 4.01;
        Double b = 5.1;

        System.out.println("Sum of " + a + " and " + b + " provided in type \"Double\" is: " + calc.summator(a, b));

        long c = 5;
        long d = 2;

        System.out.println("Division of " + c + " and " + d + " provided in type \"long\" is: " + calc.division(c, d));

        int e = 2147483647;
        int f = 2;

        System.out.println("Multiplication of " + e + " and " + f + " provided in type \"int\" is: " + calc.multiplication(e, f));

        //Проверяем конструкторы класса Gnome
        Gnome gnome1 = new Gnome("Harold");
        gnome1.getClassValues();

        Gnome gnome2 = new Gnome("Henry", true, false, true, 32);
        gnome2.getClassValues();

    }

}
